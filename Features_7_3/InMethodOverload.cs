using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{
    class InMethodOverload
    {
        Span<int> MyMethod(in int value)
        {
            // codes ...
            return null;
        }

        void MyMethod(int value)
        {
            // codes ...            
        }

    }
}
