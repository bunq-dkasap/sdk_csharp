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

            // Create serializer settings that exclude IAnchorObjectInterface to prevent infinite recursion.
            var jsonSettings = new JsonSerializerSettings {
                ContractResolver = new BunqContractResolver(new List<Type> { typeof(IAnchorObjectInterface) }),
                DateFormatString = FORMAT_DATE,
                FloatParseHandling = FloatParseHandling.Double,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            };

            // Create empty instance of the target type.
            var instance = (IAnchorObjectInterface)Activator.CreateInstance(objectType);

            // Try mapping "object" container properties to target object properties.
            if (jsonObject.TryGetValue(OBJECT_KEY, out JToken objectToken) && objectToken is JObject objectContent) {
                var properties = objectType.GetProperties();

                foreach (var property in objectContent.Properties()) {
                    if (property.Value.Type != JTokenType.Null) {
                        var targetProperty = FindMatchingProperty(properties, property.Name);

                        if (targetProperty != null) {
                            try {
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

                // Return if we successfully populated the model.
                if (!((BunqModel)instance).IsAllFieldNull()) {
                    return instance;
                }
            }

            // Try direct deserialization of the entire object.
            try {
                var model = JsonConvert.DeserializeObject(jsonObject.ToString(), objectType, jsonSettings);

                if (!((BunqModel)model).IsAllFieldNull()) {
                    return model;
                }
            } catch (System.Exception) {
                // If direct deserialization fails, continue to the field-by-field approach.
            }

            // Attempt to populate model properties by deserializing the entire JSON into each BunqModel property.
            var allProperties = objectType.GetProperties()
                .Where(p => typeof(BunqModel).IsAssignableFrom(p.PropertyType))
                .ToList();

            foreach (var property in allProperties) {
                var propertyValue = JsonConvert.DeserializeObject(
                    jsonObject.ToString(),
                    property.PropertyType,
                    jsonSettings);

                if (propertyValue != null && !((BunqModel)propertyValue).IsAllFieldNull()) {
                    property.SetValue(instance, propertyValue);
                }
            }

            return instance;
        }

        private PropertyInfo FindMatchingProperty(PropertyInfo[] properties, string jsonPropertyName)
        {
            var exactMatch = properties.FirstOrDefault(p =>
                string.Equals(p.Name, jsonPropertyName, StringComparison.OrdinalIgnoreCase));

            if (exactMatch != null)
                return exactMatch;

            return properties.FirstOrDefault(p =>
                jsonPropertyName.IndexOf(p.Name, StringComparison.OrdinalIgnoreCase) >= 0 ||
                p.Name.IndexOf(jsonPropertyName, StringComparison.OrdinalIgnoreCase) >= 0);
        }   

        public override bool CanConvert(Type objectType)
        {
            return typeof(IAnchorObjectInterface).IsAssignableFrom(objectType);
        }
    }
}
