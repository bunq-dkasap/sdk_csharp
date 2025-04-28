﻿using System;
using System.Reflection;
using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Endpoint;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Bunq.Sdk.Json
{
    public class BunqMeTabResultInquiryConverter : JsonConverter
    {
        /// <summary>
        /// Field constants.
        /// </summary>
        protected const string FIELD_PAYMENT = "payment";

        /// <summary>
        /// Object type constants.
        /// </summary>
        protected const string OBJECT_TYPE_PAYMENT = "Payment";

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            new JsonSerializer().Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            BunqMeTabResultInquiryApiObject tabResultInquiry = JsonConvert.DeserializeObject<BunqMeTabResultInquiryApiObject>(
                jsonObject.ToString(),
                GetSerializerSettingsWithoutTabResultInquiryResolver()
            );

            JObject paymentJsonObjectWrapped = (JObject) jsonObject.GetValue(FIELD_PAYMENT);
            JObject paymentJsonObject = (JObject) paymentJsonObjectWrapped.GetValue(OBJECT_TYPE_PAYMENT);

            PaymentApiObject paymentObject = PaymentApiObject.CreateFromJsonString(paymentJsonObject.ToString());
            tabResultInquiry.Payment = paymentObject;

            return tabResultInquiry;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IAnchorObjectInterface).GetTypeInfo().IsAssignableFrom(objectType);
        }

        private JsonSerializerSettings GetSerializerSettingsWithoutTabResultInquiryResolver()
        {
            return new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver()
            };
        }
    }
}