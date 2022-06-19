using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    public class SalaryIsLessException:Exception
    {
        public SalaryIsLessException(string msg):base(msg)
        {

        }
    }
}
