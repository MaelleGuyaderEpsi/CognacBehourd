using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognacBehourd
{
    public class MyException : Exception
    {
        public MyException()
        {

        }
        public MyException(string message) : base(message)
        {

        }
        public MyException(string message, Exception innerException) : base(message, innerException)
        {

        }
        
    }

    public class MyExceptionAge : Exception
    {
        public MyExceptionAge()
        {

        }
        public MyExceptionAge(string message) : base(message)
        {

        }
        public MyExceptionAge(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
