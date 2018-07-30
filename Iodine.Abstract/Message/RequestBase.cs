using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Iodine.Abstract.Message
{
    public abstract class RequestBase
    {
        [JsonProperty]
        public string RequestType { get; protected set; }

        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public static string GetType(string message)
        {
            var req = JsonConvert.DeserializeObject<Request>(message, JsonSettings);
            return req.RequestType?.ToLowerInvariant();
        }

        private class Request : RequestBase
        {

        }
    }

    public class PingRequest : RequestBase
    {
        public PingRequest()
        {
            RequestType = "Ping";
        }

        public string DeviceSerial { get; set; }
    }

    public class PlatformStatusRequest : RequestBase
    {
        public PlatformStatusRequest()
        {
            RequestType = "PlatformStatus";
        }
    }
}
