using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Features_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializer stackalloc
            InitializersOnStackalloc allocsample = new InitializersOnStackalloc();

            //MoreTypesSupportTheFixedStatement fixedSample = new MoreTypesSupportTheFixedStatement();

            //tuple comparation
            TuplesComparation comparation = new TuplesComparation();
            var cmp = comparation.UserComparation();
            Console.WriteLine(cmp);

            //outvariable
            Taxi t = new Taxi(250);


            Console.Read();
        }
    }
}
