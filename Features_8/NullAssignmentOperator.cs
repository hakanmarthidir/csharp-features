using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public class NullAssignmentOperator
    {
        public NullAssignmentOperator()
        {
            
            // ??

            double? i = null;
            double? j = i ?? 8;
            double? k = null;

            NullProcess(k);
            NullProcess(j);                

            static void NullProcess(double? myNumber)
            {
                // ??=
                var calculateRate = (myNumber ??= Math.PI) / 2;                
                Console.WriteLine(calculateRate);
            }

        }
    }
}
