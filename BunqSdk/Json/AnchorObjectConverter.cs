using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bunq.Sdk.Json
{
    public class AnchorObjectConverter : JsonConverter
    {
        private const string FORMAT_DATE = "yyyy-MM-dd HH:mm:ss.ffffff";
        private const string OBJECT_KEY = "object";

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            new JsonSerializer().Serialize(writer, value);
        }

        public override object ReadJson(
            JsonReader reader, 
            Type objectType, 
            object existingValue,
            JsonSerializer serializer
        ) {
            JObject jsonObject = JObject.Load(reader);

            var jsonSettings = new JsonSerializerSettings {
                ContractResolver = new BunqContractResolver(new List<Type> { typeof(IAnchorObjectInterface) }),
                DateFormatString = FORMAT_DATE,
                FloatParseHandling = FloatParseHandling.Double,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            };

            var instance = (IAnchorObjectInterface)Activator.CreateInstance(objectType);

            if (jsonObject.TryGetValue(OBJECT_KEY, out JToken objectToken) && objectToken is JObject objectContent) {
                var properties = objectType.GetProperties();

                foreach (var property in objectContent.Properties()) {
                    if (property.Value.Type != JTokenType.Null) {
                        var targetProperty = FindMatchingProperty(properties, property.Name);

                        if (targetProperty != null) {
                            try {
                                // Deserialize the value to the property type
                                var propertyValue = JsonConvert.DeserializeObject(
                                    property.Value.ToString(),
                                    targetProperty.PropertyType,
                                    jsonSettings);

                                targetProperty.SetValue(instance, propertyValue);
                            } catch (System.Exception) {
                                // If deserialization fails, continue to the next property
                            }
                        }
                    }
                }

                if (!((BunqModel)instance).IsAllFieldNull()) {
                    return instance;
                }
            }

            try {
                var model = JsonConvert.DeserializeObject(jsonObject.ToString(), objectType, jsonSettings);
                
                if (!((BunqModel)model).IsAllFieldNull()) {
                    return model;
                }
            } catch (System.Exception) {
                // If direct deserialization fails, continue to the field-by-field approach
            }

            var allProperties = objectType.GetProperties()
                .Where(p => typeof(BunqModel).IsAssignableFrom(p.PropertyType))
                .ToList();

            foreach (var property in allProperties) {
                try {
                    var propertyValue = JsonConvert.DeserializeObject(
                        jsonObject.ToString(),
                        property.PropertyType,
                        jsonSettings);

                    if (propertyValue != null && !((BunqModel)propertyValue).IsAllFieldNull()) {
                        property.SetValue(instance, propertyValue);
                    }
                } catch (System.Exception) {
                    // Continue with next property if this one fails
                }
            }

            return instance;
        }

        // Helper to find matching property
        private PropertyInfo FindMatchingProperty(PropertyInfo[] properties, string jsonPropertyName)
        {
            var exactMatch = properties.FirstOrDefault(p =>
                string.Equals(p.Name, jsonPropertyName, StringComparison.OrdinalIgnoreCase));

            if (exactMatch != null)
                return exactMatch;

            return properties.FirstOrDefault(p =>
                jsonPropertyName.Contains(p.Name, StringComparison.OrdinalIgnoreCase) ||
                p.Name.Contains(jsonPropertyName, StringComparison.OrdinalIgnoreCase));
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IAnchorObjectInterface).IsAssignableFrom(objectType);
        }
    }
}
