using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ObserverPattern
{
    public static class JsonSettings
    {
        public static JsonSerializerSettings GetSetings()
        {
            var settings = new JsonSerializerSettings();
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
            settings.ContractResolver = contractResolver;
            return settings;
        }
    }
}
