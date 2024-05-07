using System;

namespace ImbdApi.Exceptions
{
    public class FieldValueNullException : Exception
    {
        public FieldValueNullException() : base() { }
        public FieldValueNullException(string message) : base(message) { }
        public FieldValueNullException(string message, Exception innerException) : base(message, innerException) { } 
    }
}
