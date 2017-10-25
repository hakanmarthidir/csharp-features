using System;

namespace Features_7
{
    class LocalFunctions
    {
        //method içerisinde local methodlar tanımlanabiliyor. 
        public LocalFunctions()
        {
            void Add(int x, int y)
            {
                Console.WriteLine($"Sum of {x} and {y} is : {x + y}");
            }
            void Multiply(int x, int y)
            {
                Console.WriteLine($"Multiply of {x} and {y} is : {x * y}");
                Add(30, 10);
            }
            Add(20, 50);
            Multiply(20, 50);
        }
    }
}
