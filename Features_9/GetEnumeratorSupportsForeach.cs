using System;
using System.Collections.Generic;
using System.Linq;

namespace Features_9
{

    public static class Extensions
    {
        public static IEnumerator<T> GetEnumerator<T>(this IEnumerator<T> enumerator) => enumerator;
    }

    public class GetEnumeratorSupportsForeach
    {

        public static void WriteItems()
        {
            IEnumerator<int> enumerator = Enumerable.Range(0, 10).GetEnumerator();

            // Before C# 9: Error CS1579  foreach statement cannot operate on variables of type 'IEnumerator<string>' 
            // because 'IEnumerator<string>' does not contain a public instance or extension definition for 'GetEnumerator'
            foreach (var number in enumerator)
            {
                Console.WriteLine($"{number}");
            }

        }
    }
}