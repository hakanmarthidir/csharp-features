using System;
using System.Collections.Generic;
using System.Text;

namespace Features_14
{
    internal class NewImplicitConvertions_For_Span_ReadOnlySpan
    {
        //for many places you dont need to write the helpers like AsSpan()
        //language has natural converters for them. 

        //Some convertion types -> they are directly converted (implicit)

        // T[] → Span<T>
        // T[] → ReadOnlySpan<T>
        // Span<T> → ReadOnlySpan<T>
        // string → ReadOnlySpan<char>


        void ProcessNumbers(ReadOnlySpan<int> data)
        {
            var sum = 0;
            foreach (var x in data) sum += x;
            Console.WriteLine(sum);
        }

        void ProcessText(ReadOnlySpan<char> text)
        {
            Console.WriteLine(text[..5].ToString());
        }

        public NewImplicitConvertions_For_Span_ReadOnlySpan()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            ProcessNumbers(numbers);

            string msg = "Hello, world!";
            ProcessText(msg);


            //Span < T > → ReadOnlySpan<T>
            Span<byte> buf = stackalloc byte[256];
            buf[0] = 0x42;
            ReadOnlySpan<byte> ro = buf;

            //with slicing

            var data = new byte[] { 10, 20, 30, 40, 50 };
            ReadOnlySpan<byte> first3 = data[..3];

        }
    }
}
