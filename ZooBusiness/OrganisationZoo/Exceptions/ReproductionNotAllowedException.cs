using System;
using System.Runtime.Serialization;

namespace ZooBusiness.OrganisationZoo.Controllers
{
    [Serializable]
    internal class ReproductionNotAllowedException : Exception
    {
        public ReproductionNotAllowedException()
        {
        }

        public ReproductionNotAllowedException(string message) : base(message)
        {
        }

        public ReproductionNotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReproductionNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}