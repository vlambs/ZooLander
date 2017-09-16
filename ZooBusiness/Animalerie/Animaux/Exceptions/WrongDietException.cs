using System;
using System.Runtime.Serialization;

namespace ZooBusiness.Animalerie
{
    [Serializable]
    internal class WrongDietException : Exception
    {
        public WrongDietException() : base("Mauvais Régime")
        {
        }

        public WrongDietException(string message) : base(message)
        {
        }

        public WrongDietException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongDietException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}