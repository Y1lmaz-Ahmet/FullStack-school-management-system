using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.exceptions
{
    public class LeerlingException : Exception
    {
        public LeerlingException(string message) : base(message)
        {
        }

        public LeerlingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
