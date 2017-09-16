using System;
using System.Runtime.Serialization;

namespace ZooBusiness.Animalerie
{
    [Serializable]
    internal class SameAnimalException : Exception
    {
        public SameAnimalException() : base("Un animal ne peut se reproduire avec lui-même")
        {
        }

        public SameAnimalException(string message) : base(message)
        {
        }

        public SameAnimalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SameAnimalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}