using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Features_14
{

    //there is a new syntax on extension members. 
    //property, operator or static extensions will be possible. 

    public static class ExtensionMembersSyntax
    {        
        extension<T>(IEnumerable<T> source)
        {
            // Extension property
            public bool IsEmpty => !source.Any();

            // Extension method: filtering
            public IEnumerable<T> Where(Func<T, bool> predicate)
                => source.Where(predicate);
        }
        
        extension<T>(IEnumerable<T>)
        {
            // Static extension property: "Identity" (empty array)
            public static IEnumerable<T> Identity => Enumerable.Empty<T>();

            // Static extension method: combine two arrays
            public static IEnumerable<T> Combine(IEnumerable<T> first, IEnumerable<T> second)
                => first.Concat(second);

            // User defined operator : concat with "+"
            public static IEnumerable<T> operator +(IEnumerable<T> left, IEnumerable<T> right)
                => left.Concat(right);
        }

    }
    class Demo
    {
        static void Main()
        {
            var a = new[] { 1, 2, 3 };
            var b = new[] { 4, 5 };

            // Property usage:
            Console.WriteLine($"a.IsEmpty? {a.IsEmpty}");        // False

            // Static extension properties:
            var empty = IEnumerable<int>.Identity;               // []
            var combined1 = IEnumerable<int>.Combine(a, b);      // [1,2,3,4,5]

            // sum with Operator:
            var combined2 = a + b;                               // [1,2,3,4,5]

            
            var evens = a.Where(x => x % 2 == 0);                // [2]
            Console.WriteLine(string.Join(", ", evens));
        }
    }



}
