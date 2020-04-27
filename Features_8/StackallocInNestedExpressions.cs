using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public class StackallocInNestedExpressions
    {

        public static void UseStackAllocate(int size)
        {

            Span<int> myLuckyNumbers = stackalloc int[size];
            Random rnd = new Random();
            for (var i = 0; i < size; i++)
            {
                myLuckyNumbers[i] = rnd.Next(1, 55);
            }

            //new expression in old Span<> or ReadOnlySpan expression
            var myIndex = myLuckyNumbers.IndexOfAny(stackalloc[] { 23, 33, 45, 91 });
            Console.WriteLine($"myIndex is : {myIndex}");

        }

    }
}
