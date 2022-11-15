using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Features_11
{
    //pattern matching on lists
    internal class ListPattern
    {
        int[] numbers = { 23, 33, 91 };
        string[] names = { "a", "b", "c" };
        int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public ListPattern()
        {
            Console.WriteLine(numbers is [_, 23, _]);
            Console.WriteLine(numbers is [_, 1, _]);
            Console.WriteLine(numbers is [_, _, >= 3]);
            Console.WriteLine(numbers is [_, .., 2]);

            Console.WriteLine(names is ["", "", _]);
            Console.WriteLine(names is ["a", "b"]);
            Console.WriteLine(names is ["a", ..]);

            if (sequentialNumbers is [1, 2, 3, 4, .. var unknownNumbers, 9])
                Console.WriteLine(System.String.Join(",", unknownNumbers));

            //OUTPUT is 

            //False
            //False
            //True
            //False
            //False
            //False
            //5,6,7,8
            //True
        }
    }
}
