using System.Collections.Generic;
using System.Text;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Generated.Endpoint;
using Bunq.Sdk.Model.Generated.Object;

namespace Bunq.Sdk.Model.Core
{
    public class NotificationFilterPushUserInternal : NotificationFilterPushApiObject
    {
        /// <summary>
        /// Field constants.
        /// </summary>
        private const string OBJECT_TYPE_GET = "NotificationFilterPush";

        /// <summary>
        /// Create notification filters with list response type.
        /// </summary>
        public static BunqResponse<List<NotificationFilterPushObject>> CreateWithListResponse()
        {
            return CreateWithListResponse(new List<NotificationFilterPushObject>(), null);
        }

        /// <summary>
        /// Create notification filters with list response type.
        /// </summary>
        public static BunqResponse<List<NotificationFilterPushObject>> CreateWithListResponse(
            List<NotificationFilterPushObject> allNotificationFilter
        )
        {
            return CreateWithListResponse(allNotificationFilter, null);
        }

        /// <summary>
        /// Create notification filters with list response type.
        /// </summary>
        public static BunqResponse<List<NotificationFilterPushObject>> CreateWithListResponse(
            List<NotificationFilterPushObject> allNotificationFilter,
            Dictionary<string, string> customHeaders
        )
        {
            ApiClient apiClient = new ApiClient(GetApiContext());

            if (customHeaders == null)
            {
                customHeaders = new Dictionary<string, string>();
            }

            Dictionary<string, object> requestMap = new Dictionary<string, object>();
            requestMap.Add(FIELD_NOTIFICATION_FILTERS, allNotificationFilter);

            var requestBytes = Encoding.UTF8.GetBytes(BunqJsonConvert.SerializeObject(requestMap));
            var responseRaw = apiClient.Post(
                string.Format(ENDPOINT_URL_CREATE, DetermineUserId()),
                requestBytes,
                customHeaders);

            return FromJsonList<NotificationFilterPushObject>(responseRaw, OBJECT_TYPE_GET);
        }
    }
}