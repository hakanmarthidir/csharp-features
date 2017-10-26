using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_2
{
    public class NullableTypes
    {

        public NullableTypes()
        {
            //int decimal gibi value types degiskenler normal kosullarda null gecilemezler. default degerleri vardır. 
            //ancak belirli durumlarda bu degiskenlere gonderilen degerler olmayabilir. bu durumu yonetmek için kullanılır. 

            //bunu kullanamayız.
            //int a = null;

            //a degiskeni integera implicit bir sekilde donusum saglayamaz. convert edilmesi ve uzerinde degerin Value alınması gerekir. 
            int? a = null;

            Nullable<int> nullInteger = new Nullable<int>();
            if (nullInteger.HasValue)
            {
                int c = nullInteger.Value;
                int d = nullInteger.GetValueOrDefault(0);
            }
        }
    }
}
