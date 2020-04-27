using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    class StringInterpolation
    {
        public static void OldStyleStringComposition()
        {
            string[] @foreach = { "MJ", "SP", "DR" };
            
            for (int i = 0; i < @foreach.Length; i++)
            {
                Console.WriteLine("Member : {0} ", @foreach[i]);
            }            
        }

        public static void WithStringInterpolation(string a, int b)
        {
            // $@ or @$ 
            var yourMessage = $@"These are a : {a} and b: {b,5}";
            var yourMessage2 = $@"C:\MyFiles\Trial";
            var yourMessage3 = @$"C:\Programmes\EmptyFolder";
            Console.WriteLine($"{yourMessage} - {yourMessage2} - {yourMessage3}");
        }
    }
}
