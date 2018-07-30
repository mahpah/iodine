using System;

namespace Iodine.Abstract.Message
{
    public abstract class ResponseBase
    {
        public bool Success { get; set; }
    }

    public abstract class ResponseBase<T> : ResponseBase
    {
        public T Data { get; set; }
    }

    public class ErrorResponseData
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
    }

    public class ErrorResponse : ResponseBase<ErrorResponseData>
    {
        public ErrorResponse(int code, string message)
        {
            Data = new ErrorResponseData()
            {
                ErrorCode = code,
                Message = message
            };
        }
    }

    public class PingResponeData
    {
        public string DeviceSerial {get; set;}
        public string DeviceType {get; set;}
        public string ConnectedGateway {get; set;}
        public string Status {get; set;}
        public DateTimeOffset LastUpdate {get; set;}
    }

    public class PingResponse : ResponseBase<PingResponeData>
    {

    }

    public class PlatformStatusResponseData
    {
        public string Status { get; set; }
    }

    public class PlatformStatusResponse : ResponseBase<PlatformStatusResponse>
    {

    }
}
