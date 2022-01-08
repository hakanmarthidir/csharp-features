using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    public class MyParameter
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
    public class CallerArgumentExpressionAttributeUsage
    {
        //when you call the doSomething method with MyParameter object output will be ->  Called with : new MyParameter() { Name="", LastName="" }
        //aExpression will be a string form of related parameter
        public void DoSomething(MyParameter a, [CallerArgumentExpression("a")] string? aExpression = null)
        {
            LogParameter(aExpression);
        }

        void LogParameter(string methodParameterAsString)
        {
            Console.WriteLine($"Called with : {methodParameterAsString}");
            
        }
    }
}
