using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Exceptions
{
    public class PositionIsWrongException:Exception
    {
        public PositionIsWrongException(string msg) : base(msg)
        {

        }
    }
}
