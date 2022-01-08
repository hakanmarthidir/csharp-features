using System;
using System.Diagnostics;

namespace Features_9
{
    public class AttributesOnLocalMethods
    {
        public static void LocalFunctionsTest()
        {
            //BEFORE 9

            static void DoSomething()
            {
                Console.WriteLine("Do Something");
            }
#if DEBUG
            DoSomething();
#endif


            //with 9
            [Conditional("DEBUG")]
            static void MakeSomething()
            {
                Console.WriteLine("Make Something");
            }

            MakeSomething();









        }
    }
}
