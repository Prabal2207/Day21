using System;
namespace DAY20
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            INVALID_INPUT,
        }
        private readonly ExceptionType type;
        public UserRegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
