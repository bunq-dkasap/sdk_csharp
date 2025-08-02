using System.Collections.Generic;
using Bunq.Sdk.Context;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Endpoint;
using Bunq.Sdk.Model.Generated.Object;
using Xunit;

namespace Bunq.Sdk.Tests.Model.Core
{
    /// <summary>
    /// Tests:
    ///     NotificationFilterUrlMonetaryAccountInternal
    ///     NotificationFilterUrlUserInternal
    ///     NotificationFilterPushUserInternal
    /// </summary>
    public class NotificationFilterTest : BunqSdkTestBase, IClassFixture<NotificationFilterTest>
    {
        /// <summary>
        /// Filter constants.
        /// </summary>
        private const string FILTER_CATEGORY_MUTATION = "MUTATION";
        private const string FILTER_CALLBACK_URL = "https://test.com/callback";

        /// <summary>
        /// Test NotificationFilterUrlMonetaryAccount creation.
        /// </summary>
        [Fact]
        public void TestNotificationFilterUrlMonetaryAccount()
        {
            SetUpApiContext();

            NotificationFilterUrlObject notificationFilter = GetNotificationFilterUrl();
            List<NotificationFilterUrlObject> allCreatedNotificationFilter = NotificationFilterUrlMonetaryAccountInternal
                .CreateWithListResponse(
                    GetPrimaryMonetaryAccount().Id.Value,
                    new List<NotificationFilterUrlObject>() {notificationFilter}
                ).Value;

            Assert.True(allCreatedNotificationFilter.Count == 1);
        }

        /// <summary>
        /// Test NotificationFilterUrlUser creation.
        /// </summary>
        [Fact]
        public void TestNotificationFilterUrlUser()
        {
            SetUpApiContext();

            NotificationFilterUrlObject notificationFilter = GetNotificationFilterUrl();
            List<NotificationFilterUrlObject> allCreatedNotificationFilter = NotificationFilterUrlUserInternal
                .CreateWithListResponse(
                    new List<NotificationFilterUrlObject>() {notificationFilter}
                ).Value;

            Assert.True(allCreatedNotificationFilter.Count == 1);
        }

        /// <summary>
        /// Test NotificationFilterPushUser creation.
        /// </summary>
        [Fact]
        public void TestNotificationFilterPushUser()
        {
            SetUpApiContext();

            NotificationFilterPushObject notificationFilter = GetNotificationFilterPush();
            List<NotificationFilterPushObject> allCreatedNotificationFilter = NotificationFilterPushUserInternal
                .CreateWithListResponse(
                    new List<NotificationFilterPushObject>() {notificationFilter}
                ).Value;

            Assert.True(allCreatedNotificationFilter.Count > 1);
        }

        private NotificationFilterUrlObject GetNotificationFilterUrl()
        {
            return new NotificationFilterUrlObject(FILTER_CATEGORY_MUTATION, FILTER_CALLBACK_URL);
        }

        private NotificationFilterPushObject GetNotificationFilterPush()
        {
            return new NotificationFilterPushObject(FILTER_CATEGORY_MUTATION);
        }

        private MonetaryAccountBankApiObject GetPrimaryMonetaryAccount()
        {
            return BunqContext.UserContext.PrimaryMonetaryAccountBank;
        }
    }
}