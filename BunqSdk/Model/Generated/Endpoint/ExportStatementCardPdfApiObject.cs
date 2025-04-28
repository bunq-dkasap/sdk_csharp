using Bunq.Sdk.Context;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Used to serialize ExportStatementCardPdf
    /// </summary>
    public class ExportStatementCardPdfApiObject : BunqModel
    {
        /// <summary>
        /// Endpoint constants.
        /// </summary>
        protected const string ENDPOINT_URL_CREATE = "user/{0}/card/{1}/export-statement-card-pdf";
        protected const string ENDPOINT_URL_READ = "user/{0}/card/{1}/export-statement-card-pdf/{2}";
        protected const string ENDPOINT_URL_LISTING = "user/{0}/card/{1}/export-statement-card-pdf";
        protected const string ENDPOINT_URL_DELETE = "user/{0}/card/{1}/export-statement-card-pdf/{2}";
    
        /// <summary>
        /// Field constants.
        /// </summary>
        public const string FIELD_DATE_START = "date_start";
        public const string FIELD_DATE_END = "date_end";
    
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE_GET = "ExportStatementCardPdf";
    
        /// <summary>
        /// The date from when this statement shows transactions.
        /// </summary>
        [JsonProperty(PropertyName = "date_start")]
        public string DateStart { get; set; }
        /// <summary>
        /// The date until which statement shows transactions.
        /// </summary>
        [JsonProperty(PropertyName = "date_end")]
        public string DateEnd { get; set; }
        /// <summary>
        /// The id of the customer statement model.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
        /// <summary>
        /// The timestamp of the statement model's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }
        /// <summary>
        /// The timestamp of the statement model's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
        /// <summary>
        /// The status of the export.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// The card for which this statement was created.
        /// </summary>
        [JsonProperty(PropertyName = "card_id")]
        public int? CardId { get; set; }
    
        /// <summary>
        /// </summary>
        /// <param name="dateStart">The start date for making statements.</param>
        /// <param name="dateEnd">The end date for making statements.</param>
        public static BunqResponse<int> Create(int cardId, string dateStart, string dateEnd, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
    
            var requestMap = new Dictionary<string, object>
    {
    {FIELD_DATE_START, dateStart},
    {FIELD_DATE_END, dateEnd},
    };
    
            var requestBytes = Encoding.UTF8.GetBytes(BunqJsonConvert.SerializeObject(requestMap));
            var responseRaw = apiClient.Post(string.Format(ENDPOINT_URL_CREATE, DetermineUserId(), cardId), requestBytes, customHeaders);
    
            return ProcessForId(responseRaw);
        }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<ExportStatementCardPdfApiObject> Get(int cardId, int exportStatementCardPdfId, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_READ, DetermineUserId(), cardId, exportStatementCardPdfId), new Dictionary<string, string>(), customHeaders);
    
            return FromJson<ExportStatementCardPdfApiObject>(responseRaw, OBJECT_TYPE_GET);
        }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<List<ExportStatementCardPdfApiObject>> List(int cardId, IDictionary<string, string> urlParams = null, IDictionary<string, string> customHeaders = null)
        {
            if (urlParams == null) urlParams = new Dictionary<string, string>();
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_LISTING, DetermineUserId(), cardId), urlParams, customHeaders);
    
            return FromJsonList<ExportStatementCardPdfApiObject>(responseRaw, OBJECT_TYPE_GET);
        }
    
        /// <summary>
        /// </summary>
        public static BunqResponse<object> Delete(int cardId, int exportStatementCardPdfId, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Delete(string.Format(ENDPOINT_URL_DELETE, DetermineUserId(), cardId, exportStatementCardPdfId), customHeaders);
    
            return new BunqResponse<object>(null, responseRaw.Headers);
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Id != null)
            {
                return false;
            }
    
            if (this.Created != null)
            {
                return false;
            }
    
            if (this.Updated != null)
            {
                return false;
            }
    
            if (this.DateStart != null)
            {
                return false;
            }
    
            if (this.DateEnd != null)
            {
                return false;
            }
    
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.CardId != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static ExportStatementCardPdfApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<ExportStatementCardPdfApiObject>(json);
        }
    }
}
