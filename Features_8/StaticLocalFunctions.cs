using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public class StaticLocalFunctions
    {
        public static void TriangleFindC(double a, double b)
        {
            var totalValue = Pisagor(a, b);
            //var totalValue = Pisagor2(a, b);
            Console.WriteLine($"C is : {Math.Sqrt(totalValue)}");

            static double Pisagor(double x, double y) => Math.Pow(x, 2) + Math.Pow(y, 2); 
            
            //static double Pisagor2(double x, double y) {
            //    return Math.Pow(x, 2) + Math.Pow(y, 2);
            //}
        
        }
    }
}
