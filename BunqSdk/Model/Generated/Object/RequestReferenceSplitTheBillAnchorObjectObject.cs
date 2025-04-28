using Bunq.Sdk.Exception;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Endpoint;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class RequestReferenceSplitTheBillAnchorObjectObject : BunqModel, IAnchorObjectInterface
    {
        /// <summary>
        /// Error constants.
        /// </summary>
        private const string ERROR_NULL_FIELDS = "All fields of an extended model or object are null.";
    
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BillingInvoice")]
        public InvoiceApiObject BillingInvoice { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DraftPayment")]
        public DraftPaymentApiObject DraftPayment { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MasterCardAction")]
        public MasterCardActionApiObject MasterCardAction { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Payment")]
        public PaymentApiObject Payment { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PaymentBatch")]
        public PaymentBatchApiObject PaymentBatch { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequestResponse")]
        public RequestResponseApiObject RequestResponse { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ScheduleInstance")]
        public ScheduleInstanceApiObject ScheduleInstance { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WhitelistResult")]
        public WhitelistResultApiObject WhitelistResult { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TransferwisePayment")]
        public TransferwiseTransferApiObject TransferwisePayment { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CurrencyConversion")]
        public CurrencyConversionApiObject CurrencyConversion { get; set; }
    
    
        /// <summary>
        /// </summary>
        public BunqModel GetReferencedObject()
        {
            if (this.BillingInvoice != null)
            {
                return this.BillingInvoice;
            }
    
            if (this.DraftPayment != null)
            {
                return this.DraftPayment;
            }
    
            if (this.MasterCardAction != null)
            {
                return this.MasterCardAction;
            }
    
            if (this.Payment != null)
            {
                return this.Payment;
            }
    
            if (this.PaymentBatch != null)
            {
                return this.PaymentBatch;
            }
    
            if (this.RequestResponse != null)
            {
                return this.RequestResponse;
            }
    
            if (this.ScheduleInstance != null)
            {
                return this.ScheduleInstance;
            }
    
            if (this.WhitelistResult != null)
            {
                return this.WhitelistResult;
            }
    
            if (this.TransferwisePayment != null)
            {
                return this.TransferwisePayment;
            }
    
            if (this.CurrencyConversion != null)
            {
                return this.CurrencyConversion;
            }
    
            throw new BunqException(ERROR_NULL_FIELDS);
        }
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.BillingInvoice != null)
            {
                return false;
            }
    
            if (this.DraftPayment != null)
            {
                return false;
            }
    
            if (this.MasterCardAction != null)
            {
                return false;
            }
    
            if (this.Payment != null)
            {
                return false;
            }
    
            if (this.PaymentBatch != null)
            {
                return false;
            }
    
            if (this.RequestResponse != null)
            {
                return false;
            }
    
            if (this.ScheduleInstance != null)
            {
                return false;
            }
    
            if (this.WhitelistResult != null)
            {
                return false;
            }
    
            if (this.TransferwisePayment != null)
            {
                return false;
            }
    
            if (this.CurrencyConversion != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static RequestReferenceSplitTheBillAnchorObjectObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<RequestReferenceSplitTheBillAnchorObjectObject>(json);
        }
    }
}
