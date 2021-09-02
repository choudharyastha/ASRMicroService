using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro.Common.Exceptions
{
    public class MicroException:Exception
    {
        public MicroException()
        {
        }

        public MicroException(string message)
            : base(message)
        {
        }

        public MicroException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
