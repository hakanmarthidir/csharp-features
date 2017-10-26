using System;
using System.Linq;

namespace Features_3
{
    class LambdaExpressions
    {
        //OldStyle
        delegate int del(int i);
        public LambdaExpressions()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Console.WriteLine(j);
        }

        public void LambdaMethod()
        {
            //Lambda
            // anonymous delegate
            var evens1 = Enumerable
                            .Range(1, 100)
                            .Where(delegate (int x) { return (x % 2) == 0; })
                            .ToList();

            // lambda expression
            var evens2 = Enumerable
                            .Range(1, 100)
                            .Where(x => (x % 2) == 0)
                            .ToList();
        }
    }


}
