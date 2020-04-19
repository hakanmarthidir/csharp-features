using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{
    class RefLocalVariablesAssignable
    {

        void MyRefMethod(ref int mynumber, ref int mynumber2)
        {
            ref var refnumber = ref mynumber;
            refnumber = ref mynumber2;
        }
    }
}
