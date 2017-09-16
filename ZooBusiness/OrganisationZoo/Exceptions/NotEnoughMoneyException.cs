using System;
using System.Runtime.Serialization;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    [Serializable]
    internal class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException() : base("Pas assez d'argent dans la caisse !")
        {
        }

        public NotEnoughMoneyException(string message) : base(message)
        {
        }

        public NotEnoughMoneyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughMoneyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}