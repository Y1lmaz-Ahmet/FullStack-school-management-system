using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.exceptions
{
    public class MensException : Exception
    {
        public MensException(string message) : base(message)
        {
        }

        public MensException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
