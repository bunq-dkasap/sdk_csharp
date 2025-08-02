﻿using System.Linq;
using Bunq.Sdk.Model.Generated.Endpoint;
using Bunq.Sdk.Model.Generated.Object;
using Xunit;

namespace Bunq.Sdk.Tests.Model.Generated.Endpoint
{
    /// <summary>
    /// Tests:
    ///     Payment
    /// </summary>
    public class PaymentTest : BunqSdkTestBase
    {
        /// <summary>
        /// Tests making a payment to another sandbox user.
        ///
        /// This test has no assertion as it is testing to see if the code runs without errors.
        /// </summary>
        [Fact]
        public void TestMakePaymentToOtherUser()
        {
            SetUpTestCase();

            PaymentApiObject.Create(new AmountObject(PaymentAmountEur, PaymentCurrency), GetPointerBravo(), PaymentDescription);
        }

        /// <summary>
        /// Tests making a payment to another monetary account.
        ///
        /// This test has no assertion as it is testing to see if the code runs without errors.
        /// </summary>
        [Fact]
        public void TestMakePaymentToOtherAccount()
        {
            SetUpTestCase();

            PaymentApiObject.Create(
                new AmountObject(PaymentAmountEur, PaymentCurrency),
                SecondMonetaryAccountBank.Alias.First(),
                PaymentDescription
            );
        }
    }
}