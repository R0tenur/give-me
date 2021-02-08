using System;
using System.Runtime.Serialization;

namespace GiveMe
{
    [Serializable]
    internal class CommandHandlerNotFoundException : Exception
    {
        private Type type;

        public CommandHandlerNotFoundException()
        {
        }

        public CommandHandlerNotFoundException(Type type)
        {
            this.type = type;
        }

        public CommandHandlerNotFoundException(string message) : base(message)
        {
        }

        public CommandHandlerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CommandHandlerNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}