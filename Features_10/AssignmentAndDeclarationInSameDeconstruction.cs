using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    internal class AssignmentAndDeclarationInSameDeconstruction
    {
        public AssignmentAndDeclarationInSameDeconstruction()
        {

            //c# 9 and before
            //1. you should define variables initialization before process 
            int a = 0;
            int b = 0;
            (a, b) = (33, 23);
            //or 2. you should define variables initialization during process
            (int c, int d) = (33, 23);


            //but now with c# 10 
            int f;
            (f, int g) = (33, 23);    

        }
    }
}
