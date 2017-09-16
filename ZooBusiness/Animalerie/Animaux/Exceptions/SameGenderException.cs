using System;
using System.Runtime.Serialization;

namespace ZooBusiness.Animalerie
{
    [Serializable]
    internal class SameGenderException : Exception
    {
        public SameGenderException() : base("Deux animaux du même sexe ne peuvent se reproduire !")
        {
        }

        public SameGenderException(string message) : base(message)
        {
        }

        public SameGenderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SameGenderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}