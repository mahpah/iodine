using System;

namespace Iodine.Abstract.Exceptions
{
    public class PlatformError : Exception
    {
        public PlatformError(int code, string message) : base(message)
        {
            Code = code;
        }
        
        public int Code { get; set; }
    }
}
