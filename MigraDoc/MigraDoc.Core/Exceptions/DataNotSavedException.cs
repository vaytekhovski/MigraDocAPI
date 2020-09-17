using System;

namespace Com.SNGJob.Core.Exceptions
{
    [Serializable]
    public class DataNotSavedException : HandledException
    {
        public DataNotSavedException(ExceptionCode code) : base(code)
        {
        }
    }

    [Serializable]
    public class UserCreateFailedException : DataNotSavedException
    {
        public UserCreateFailedException() : base(ExceptionCode.UserCreateFailed)
        {
        }
    }

    [Serializable]
    public class UserUpdateFailedException : DataNotSavedException
    {
        public UserUpdateFailedException() : base(ExceptionCode.UserUpdateFailed)
        {
        }
    }
}