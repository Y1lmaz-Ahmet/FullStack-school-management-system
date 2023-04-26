using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.exceptions
{
    public class AdministratiefMedewerkerException : Exception
    {
        

        public AdministratiefMedewerkerException(string message) : base(message)
        {
        }

        public AdministratiefMedewerkerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AdministratiefMedewerkerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
