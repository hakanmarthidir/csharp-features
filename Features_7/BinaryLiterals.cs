using System;

namespace Features_7
{
    class BinaryLiterals
    {
        public BinaryLiterals()
        {
            //Binary tanımlamalarda kolaylık
            int Int32MaxLengthInDecimal = 2147483647;
            int Int32MaxLengthInHexaDecimal = 0x7FFFFFFF;
            Console.WriteLine($"InDecimal {Int32MaxLengthInDecimal}");
            Console.WriteLine($"InHexaDecimal {Int32MaxLengthInHexaDecimal}");
        }
    }
}
