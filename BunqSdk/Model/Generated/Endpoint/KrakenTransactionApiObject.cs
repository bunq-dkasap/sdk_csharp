using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Create Kraken Quote.
    /// </summary>
    public class KrakenTransactionApiObject : BunqModel
    {
        /// <summary>
        /// The status of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        /// <summary>
        /// The status of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "status_description")]
        public string StatusDescription { get; set; }
        /// <summary>
        /// The translated status of the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "status_description_translated")]
        public string StatusDescriptionTranslated { get; set; }
        /// <summary>
        /// Type of the order.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive without fees.
        /// </summary>
        [JsonProperty(PropertyName = "amount_order_source")]
        public AmountObject AmountOrderSource { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive.
        /// </summary>
        [JsonProperty(PropertyName = "amount_billing_source")]
        public AmountObject AmountBillingSource { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive without fees in their currency.
        /// </summary>
        [JsonProperty(PropertyName = "amount_order_source_local")]
        public AmountObject AmountOrderSourceLocal { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive in their currency.
        /// </summary>
        [JsonProperty(PropertyName = "amount_billing_source_local")]
        public AmountObject AmountBillingSourceLocal { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive without fees.
        /// </summary>
        [JsonProperty(PropertyName = "amount_order_target")]
        public AmountObject AmountOrderTarget { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive.
        /// </summary>
        [JsonProperty(PropertyName = "amount_billing_target")]
        public AmountObject AmountBillingTarget { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive without fees in their currency.
        /// </summary>
        [JsonProperty(PropertyName = "amount_order_target_local")]
        public AmountObject AmountOrderTargetLocal { get; set; }
        /// <summary>
        /// The final amount the user will pay or receive in their currency.
        /// </summary>
        [JsonProperty(PropertyName = "amount_billing_target_local")]
        public AmountObject AmountBillingTargetLocal { get; set; }
        /// <summary>
        /// The fee the user will pay.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee")]
        public AmountObject AmountFee { get; set; }
        /// <summary>
        /// The fee the user will pay in their currency.
        /// </summary>
        [JsonProperty(PropertyName = "amount_fee_local")]
        public AmountObject AmountFeeLocal { get; set; }
        /// <summary>
        /// The unit price amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount_unit_price")]
        public AmountObject AmountUnitPrice { get; set; }
        /// <summary>
        /// External identifier of this order at Kraken.
        /// </summary>
        [JsonProperty(PropertyName = "external_identifier")]
        public string ExternalIdentifier { get; set; }
        /// <summary>
        /// The label of the user.
        /// </summary>
        [JsonProperty(PropertyName = "label_user")]
        public MonetaryAccountReference LabelUser { get; set; }
        /// <summary>
        /// The label of the monetary account.
        /// </summary>
        [JsonProperty(PropertyName = "label_monetary_account")]
        public MonetaryAccountReference LabelMonetaryAccount { get; set; }
        /// <summary>
        /// The label of the counter monetary account.
        /// </summary>
        [JsonProperty(PropertyName = "counter_label_monetary_account")]
        public MonetaryAccountReference CounterLabelMonetaryAccount { get; set; }
        /// <summary>
        /// The id of the event of transaction.
        /// </summary>
        [JsonProperty(PropertyName = "event_id")]
        public long? EventId { get; set; }
        /// <summary>
        /// The requested asset name, used to display the right side of this transaction.
        /// </summary>
        [JsonProperty(PropertyName = "asset_name_requested")]
        public string AssetNameRequested { get; set; }
        /// <summary>
        /// Source of this kraken transaction.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        /// <summary>
        /// Fee breakdown of this transaction's quote..
        /// </summary>
        [JsonProperty(PropertyName = "quote_fee")]
        public KrakenQuoteFeeObject QuoteFee { get; set; }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.StatusDescription != null)
            {
                return false;
            }
    
            if (this.StatusDescriptionTranslated != null)
            {
                return false;
            }
    
            if (this.Type != null)
            {
                return false;
            }
    
            if (this.AmountOrderSource != null)
            {
                return false;
            }
    
            if (this.AmountBillingSource != null)
            {
                return false;
            }
    
            if (this.AmountOrderSourceLocal != null)
            {
                return false;
            }
    
            if (this.AmountBillingSourceLocal != null)
            {
                return false;
            }
    
            if (this.AmountOrderTarget != null)
            {
                return false;
            }
    
            if (this.AmountBillingTarget != null)
            {
                return false;
            }
    
            if (this.AmountOrderTargetLocal != null)
            {
                return false;
            }
    
            if (this.AmountBillingTargetLocal != null)
            {
                return false;
            }
    
            if (this.AmountFee != null)
            {
                return false;
            }
    
            if (this.AmountFeeLocal != null)
            {
                return false;
            }
    
            if (this.AmountUnitPrice != null)
            {
                return false;
            }
    
            if (this.ExternalIdentifier != null)
            {
                return false;
            }
    
            if (this.LabelUser != null)
            {
                return false;
            }
    
            if (this.LabelMonetaryAccount != null)
            {
                return false;
            }
    
            if (this.CounterLabelMonetaryAccount != null)
            {
                return false;
            }
    
            if (this.EventId != null)
            {
                return false;
            }
    
            if (this.AssetNameRequested != null)
            {
                return false;
            }
    
            if (this.Source != null)
            {
                return false;
            }
    
            if (this.QuoteFee != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static KrakenTransactionApiObject CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<KrakenTransactionApiObject>(json);
        }
    }
}
