using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    internal class LambdaImprovements
    {
        public LambdaImprovements()
        {
            //c# 10
            //1. you can catch the return value with var
            var result = (string s) => s.Trim();
            var readConsole = Console.ReadLine;
            //var writeConsole = Console.WriteLine;  not valid because it has many overload variations


            //2. Explicit Return Type 
            var test1 = () => "Test";
            var test2 = () => (double)23;


            //3. You can use Attributes with lambda
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions#attributes 

            //Func<string, int> parse =[Example(1)] (s) => int.Parse(s);
            //var choose =[Example(2)][Example(3)] object (bool b) => b ? 1 : "two";

            //var sum = ([Example(1)] int a, [Example(2), Example(3)] int b) => a + b;
            //var inc =[return: Example(1)] (int s) => s++;

        }
    }
}
