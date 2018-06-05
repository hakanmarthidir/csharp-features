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
            //Bu nedenle asagidaki kod hata verecektir. 
            //name = "asdasd";
        }

    }
}
