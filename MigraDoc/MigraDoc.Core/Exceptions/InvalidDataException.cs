using System;

namespace Com.SNGJob.Core.Exceptions
{
    [Serializable]
    public class InvalidDataException : HandledException
    {
        public InvalidDataException(ExceptionCode code) : base(code)
        {
        }
    }

    [Serializable]
    public class UserTelegramIdNotValidException : InvalidDataException
    {
        public UserTelegramIdNotValidException() : base(ExceptionCode.UserTelegramIdNotValid)
        {
        }
    }
}