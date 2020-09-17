using System;

namespace Com.SNGJob.Core.Exceptions
{
    [Serializable]
    public class NotFoundException : HandledException
    {
        public NotFoundException(ExceptionCode code) : base(code)
        {
        }
    }

    
    [Serializable]
    public class TelegramUserNotFoundException : NotFoundException
    {
        public TelegramUserNotFoundException() : base(ExceptionCode.UserTelegramIdNotFound)
        {
        }
    }
    
    
    [Serializable]
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException() : base(ExceptionCode.UserIdNotFound)
        {
        }
    }

    [Serializable]
    public class PhoneNotFoundException : NotFoundException
    {
        public PhoneNotFoundException() : base(ExceptionCode.UserPhoneNotFound)
        {
        }
    }
}