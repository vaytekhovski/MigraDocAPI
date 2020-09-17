using System;

namespace Com.SNGJob.Core.Exceptions
{
    [Serializable]
    public class HandledExceptionMessage
    {
        public ExceptionCode Code { get; set; }

        public string StackTrace { get; set; }
        
        public string Message { get; set; }
    }

    [Serializable]
    public class HandledException : Exception
    {
        private readonly ExceptionCode _code;

        public HandledException(ExceptionCode code) : base($"EXCEPTION:{code};")
        {
            _code = code;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HandledExceptionMessage GetMessageObject()
        {
            return new HandledExceptionMessage
            {
                Code = _code,
                StackTrace = StackTrace,
                Message = Message
            };
        }
    }
}