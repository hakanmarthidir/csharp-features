using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Features_11
{
    // Normally it has implemented with Net6, in Net7 some features was added.
    // static virtual or static abstract methods
    // shift operators
    // unsigned right shift operator


    public class GenericMath
    {
        public static T Sum<T>(T item1, T item2) where T : INumber<T>
        {
            return item1 + item2;
        }

        public static T Sum<T>(T[] numbers) where T : INumber<T>
        {
            T result = T.Zero;
            foreach (var n in numbers)
            {
                result += n;
            }
            return result;
        }
    }
}
