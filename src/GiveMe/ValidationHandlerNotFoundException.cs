using System;
using System.Runtime.Serialization;

namespace GiveMe
{
    [Serializable]
    internal class ValidationHandlerNotFoundException : Exception
    {
        private Type type;

        public ValidationHandlerNotFoundException()
        {
        }

        public ValidationHandlerNotFoundException(Type type)
        {
            this.type = type;
        }

        public ValidationHandlerNotFoundException(string message) : base(message)
        {
        }

        public ValidationHandlerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidationHandlerNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}