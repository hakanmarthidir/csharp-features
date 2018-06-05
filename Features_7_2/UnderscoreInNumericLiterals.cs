using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    class UnderscoreInNumericLiterals
    {
        //Hex ve Binary degerleri tanımlarken artık içerisinde _ kullanımına izin veriliyor. 
        public void HexBinaryDefine()
        {
            int binaryValue = 0b_0010_0011;
        }
    }
}
