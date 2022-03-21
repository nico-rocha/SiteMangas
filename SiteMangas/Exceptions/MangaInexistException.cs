using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Exceptions
{
    class MangaInexistException : ApplicationException
    {
        public MangaInexistException(string message) : base(message)
        {

        }
    }
}
