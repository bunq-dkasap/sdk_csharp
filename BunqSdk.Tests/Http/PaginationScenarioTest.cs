using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Generated.Endpoint;
using Bunq.Sdk.Model.Generated.Object;
using Xunit;

namespace Bunq.Sdk.Tests.Http
{
    /// <summary>
    /// Tests:
    ///     Pagination
    /// </summary>
    public class PaginationScenarioTest : BunqSdkTestBase
    {
        /// <summary>
        /// Constants for scenario testing.
        /// </summary>
        private const int PaymentListingPageSize = 2;
        private const int PaymentRequiredCountMinimum = PaymentListingPageSize * 2;
        private const int NumberZero = 0;

        [Fact]
        public void TestApiScenarioPaymentListingWithPagination()
        {
            SetUpTestCase();

            EnsureEnoughPayments();
            var paymentsExpected = new List<PaymentApiObject>(GetPaymentsRequired());
            var paginationCountOnly = new Pagination
            {
                Count = PaymentListingPageSize
            };
            
            Thread.Sleep(1000); 
            var responseLatest = ListPayments(paginationCountOnly.UrlParamsCountOnly);
            
            Thread.Sleep(1000);
            var paginationLatest = responseLatest.Pagination;
            var responsePrevious = ListPayments(paginationLatest.UrlParamsPreviousPage);
            
            Thread.Sleep(1000);
            var paginationPrevious = responsePrevious.Pagination;
            var responsePreviousNext = ListPayments(paginationPrevious.UrlParamsNextPage);

            var paymentsActual = new List<PaymentApiObject>();
            paymentsActual.AddRange(responsePreviousNext.Value);
            paymentsActual.AddRange(responsePrevious.Value);
            var paymentsExpectedSerialized = BunqJsonConvert.SerializeObject(paymentsExpected);
            var paymentsActualSerialized = BunqJsonConvert.SerializeObject(paymentsActual);

            Assert.Equal(paymentsExpectedSerialized, paymentsActualSerialized);
        }

        private static void EnsureEnoughPayments()
        {
            for (var i = NumberZero; i < GetPaymentsMissingCount(); ++i)
            {
                Thread.Sleep(1000); // Time out to prevent rate limiting.
                CreatePayment();
            }
        }

        private static int GetPaymentsMissingCount()
        {
            return PaymentRequiredCountMinimum - GetPaymentsRequired().Count;
        }

        private static IList<PaymentApiObject> GetPaymentsRequired()
        {
            var pagination = new Pagination
            {
                Count = PaymentRequiredCountMinimum
            };

            return ListPayments(pagination.UrlParamsCountOnly).Value;
        }

        private static BunqResponse<List<PaymentApiObject>> ListPayments(IDictionary<string, string> urlParams)
        {
            return PaymentApiObject.List(urlParams: urlParams);
        }

        private static void CreatePayment()
        {
            PaymentApiObject.Create(new AmountObject(PaymentAmountEur, PaymentCurrency), GetPointerBravo(), PaymentDescription);
        }
    }
}