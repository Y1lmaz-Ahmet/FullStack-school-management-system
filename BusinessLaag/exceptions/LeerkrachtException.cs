using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.exceptions
{
    public class LeerkrachtException : Exception
    {
        

        public LeerkrachtException(string message) : base(message)
        {
        }

        public LeerkrachtException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LeerkrachtException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
