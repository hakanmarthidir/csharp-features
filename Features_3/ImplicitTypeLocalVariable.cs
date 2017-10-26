using System.Collections.Generic;

namespace Features_3
{
    public class ImplicitTypeLocalVariable
    {
        public ImplicitTypeLocalVariable()
        {
            // compiled as int. 
            var i = 23;

            // compiled as string
            var s = "Hakan";

            // compiled as int[]
            var a = new[] { 0, 1, 2 };

            // compiled as List<int>                             
            var list = new List<int>();
        }
    }


}
