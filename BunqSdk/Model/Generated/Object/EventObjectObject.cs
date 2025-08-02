using Bunq.Sdk.Exception;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Endpoint;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class EventObjectObject : BunqModel, IAnchorObjectInterface
    {
        /// <summary>
        /// Error constants.
        /// </summary>
        private const string ERROR_NULL_FIELDS = "All fields of an extended model or object are null.";
    
    
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BunqMeTab")]
        public BunqMeTabApiObject BunqMeTab { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BunqMeTabResultResponse")]
        public BunqMeTabResultResponseApiObject BunqMeTabResultResponse { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BunqMeFundraiserResult")]
        public BunqMeFundraiserResultApiObject BunqMeFundraiserResult { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Card")]
        public CardApiObject Card { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CardDebit")]
        public CardDebitApiObject CardDebit { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DraftPayment")]
        public DraftPaymentApiObject DraftPayment { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FeatureAnnouncement")]
        public FeatureAnnouncementApiObject FeatureAnnouncement { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IdealMerchantTransaction")]
        public IdealMerchantTransactionApiObject IdealMerchantTransaction { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Invoice")]
        public InvoiceApiObject Invoice { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ScheduledPayment")]
        public SchedulePaymentApiObject ScheduledPayment { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ScheduledPaymentBatch")]
        public SchedulePaymentBatchApiObject ScheduledPaymentBatch { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ScheduledInstance")]
        public ScheduleInstanceApiObject ScheduledInstance { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MasterCardAction")]
        public MasterCardActionApiObject MasterCardAction { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BankSwitchServiceNetherlandsIncomingPayment")]
        public BankSwitchServiceNetherlandsIncomingPaymentApiObject BankSwitchServiceNetherlandsIncomingPayment { get; set; }
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
        [JsonProperty(PropertyName = "RequestInquiryBatch")]
        public RequestInquiryBatchApiObject RequestInquiryBatch { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequestInquiry")]
        public RequestInquiryApiObject RequestInquiry { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequestResponse")]
        public RequestResponseApiObject RequestResponse { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShareInviteBankInquiry")]
        public ShareInviteMonetaryAccountInquiryApiObject ShareInviteBankInquiry { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ShareInviteBankResponse")]
        public ShareInviteMonetaryAccountResponseApiObject ShareInviteBankResponse { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SofortMerchantTransaction")]
        public SofortMerchantTransactionApiObject SofortMerchantTransaction { get; set; }
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TransferwisePayment")]
        public TransferwiseTransferApiObject TransferwisePayment { get; set; }
    
    
        /// <summary>
        /// </summary>
        public BunqModel GetReferencedObject()
        {
            if (this.BunqMeTab != null)
            {
                return this.BunqMeTab;
            }
    
            if (this.BunqMeTabResultResponse != null)
            {
                return this.BunqMeTabResultResponse;
            }
    
            if (this.BunqMeFundraiserResult != null)
            {
                return this.BunqMeFundraiserResult;
            }
    
            if (this.Card != null)
            {
                return this.Card;
            }
    
            if (this.CardDebit != null)
            {
                return this.CardDebit;
            }
    
            if (this.DraftPayment != null)
            {
                return this.DraftPayment;
            }
    
            if (this.FeatureAnnouncement != null)
            {
                return this.FeatureAnnouncement;
            }
    
            if (this.IdealMerchantTransaction != null)
            {
                return this.IdealMerchantTransaction;
            }
    
            if (this.Invoice != null)
            {
                return this.Invoice;
            }
    
            if (this.ScheduledPayment != null)
            {
                return this.ScheduledPayment;
            }
    
            if (this.ScheduledPaymentBatch != null)
            {
                return this.ScheduledPaymentBatch;
            }
    
            if (this.ScheduledInstance != null)
            {
                return this.ScheduledInstance;
            }
    
            if (this.MasterCardAction != null)
            {
                return this.MasterCardAction;
            }
    
            if (this.BankSwitchServiceNetherlandsIncomingPayment != null)
            {
                return this.BankSwitchServiceNetherlandsIncomingPayment;
            }
    
            if (this.Payment != null)
            {
                return this.Payment;
            }
    
            if (this.PaymentBatch != null)
            {
                return this.PaymentBatch;
            }
    
            if (this.RequestInquiryBatch != null)
            {
                return this.RequestInquiryBatch;
            }
    
            if (this.RequestInquiry != null)
            {
                return this.RequestInquiry;
            }
    
            if (this.RequestResponse != null)
            {
                return this.RequestResponse;
            }
    
            if (this.ShareInviteBankInquiry != null)
            {
                return this.ShareInviteBankInquiry;
            }
    
            if (this.ShareInviteBankResponse != null)
            {
                return this.ShareInviteBankResponse;
            }
    
            if (this.SofortMerchantTransaction != null)
            {
                return this.SofortMerchantTransaction;
            }
    
            if (this.TransferwisePayment != null)
            {
                return this.TransferwisePayment;
            }
    
            throw new BunqException(ERROR_NULL_FIELDS);
        }
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.BunqMeTab != null)
            {
                return false;
            }
    
            if (this.BunqMeTabResultResponse != null)
            {
                return false;
            }
    
            if (this.BunqMeFundraiserResult != null)
            {
                return false;
            }
    
            if (this.Card != null)
            {
                return false;
            }
    
            if (this.CardDebit != null)
            {
                return false;
            }
    
            if (this.DraftPayment != null)
            {
                return false;
            }
    
            if (this.FeatureAnnouncement != null)
            {
                return false;
            }
    
            if (this.IdealMerchantTransaction != null)
            {
                return false;
            }
    
            if (this.Invoice != null)
            {
                return false;
            }
    
            if (this.ScheduledPayment != null)
            {
                return false;
            }
    
            if (this.ScheduledPaymentBatch != null)
            {
                return false;
            }
    
            if (this.ScheduledInstance != null)
            {
                return false;
            }
    
            if (this.MasterCardAction != null)
            {
                return false;
            }
    
            if (this.BankSwitchServiceNetherlandsIncomingPayment != null)
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
    
            if (this.RequestInquiryBatch != null)
            {
                return false;
            }
    
            if (this.RequestInquiry != null)
            {
                return false;
            }
    
            if (this.RequestResponse != null)
            {
                return false;
            }
    
            if (this.ShareInviteBankInquiry != null)
            {
                return false;
            }
    
            if (this.ShareInviteBankResponse != null)
            {
                return false;
            }
    
            if (this.SofortMerchantTransaction != null)
            {
                return false;
            }
    
            if (this.TransferwisePayment != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static EventObjectObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<EventObjectObject>(json);
        }
    }
}
