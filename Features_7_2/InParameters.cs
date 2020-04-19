using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    public class InParameterTest
    {

        public void MethodWithInParameter(in string name)
        {
            //Methodlara verilen parametrelerin readonly bir sekilde davranmasını saglayan keyworddur.
            //Foreach veya LINQ ile kullanılabilir. 

            //Asagidaki kod hata verecektir.
            //name = "asdasd";
        }

        //Ref, Out, In ile overload edilemez. Aşağıdaki method tanımı hata verecektir. 

        //public void MethodWithInParameter(ref string name)
        //{            
        //}

        //public void MethodWithInParameter(out string name)
        //{            
        //}
    }
}
