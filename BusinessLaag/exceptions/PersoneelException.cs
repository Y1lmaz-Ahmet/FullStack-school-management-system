using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.exceptions
{
    internal class PersoneelException : Exception
    {
       

        public PersoneelException(string message) : base(message)
        {
        }

        public PersoneelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PersoneelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
