using System;

namespace Com.SNGJob.Core.Exceptions
{
    [Serializable]
    public class UserAlreadyExistsException : HandledException
    {
        public UserAlreadyExistsException(ExceptionCode code) : base(code)
        {
        }
    }

    [Serializable]
    public class TelegramUserAlreadyExistsException : UserAlreadyExistsException
    {
        public TelegramUserAlreadyExistsException() : base(ExceptionCode.UserTelegramIdAlreadyExists)
        {
        }
    }

    [Serializable]
    public class UserPhoneAlreadyExistsException : UserAlreadyExistsException
    {
        public UserPhoneAlreadyExistsException() : base(ExceptionCode.UserPhoneAlreadyExists)
        {
        }
    }
}