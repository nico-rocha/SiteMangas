using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Exceptions
{
    class OptionInexistException : ApplicationException
    {
        public OptionInexistException(string message) :  base(message)
        {

        }
    }
}
