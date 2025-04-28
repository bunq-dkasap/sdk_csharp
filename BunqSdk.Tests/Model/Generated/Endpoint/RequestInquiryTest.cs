﻿using System.Collections.Generic;
using System.Linq;
using Bunq.Sdk.Model.Generated.Endpoint;
using Bunq.Sdk.Model.Generated.Object;
using Xunit;

namespace Bunq.Sdk.Tests.Model.Generated.Endpoint
{
    /// <summary>
    /// Tests:
    ///     RequestInquiry
    ///     RequestResponse
    /// </summary>
    public class RequestInquiryTest : BunqSdkTestBase
    {
        /// <summary>
        /// The status for accepting a request. 
        /// </summary>
        private const string Status = "ACCEPTED";

        /// <summary>
        /// Tests sending a request from monetary account 1 to monetary account 2 and accepting this request.
        /// </summary>
        [Fact]
        public void TestRequestInquiry()
        {
            SetUpTestCase();

            RequestInquiryApiObject.Create(
                new AmountObject(PaymentAmountEur, PaymentCurrency),
                SecondMonetaryAccountBank.Alias.First(),
                PaymentDescription,
                false
            );

            Assert.Equal(Status, AcceptRequest());
        }

        private static string AcceptRequest()
        {
            var urlParams = new Dictionary<string, string>();
            urlParams["status"] = "PENDING";
            var requestResponseId = RequestResponseApiObject.List(SecondMonetaryAccountBank.Id.Value, urlParams).Value.First().Id.Value;

            return RequestResponseApiObject.Update(
                requestResponseId,
                status: Status,
                monetaryAccountId: SecondMonetaryAccountBank.Id.Value
            ).Value.Status;
        }
    }
}