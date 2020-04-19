using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{
    public class Car
    {
        public Car(int maxSpeed, out int oillevel)
        {
            oillevel = 100;
        }
    }


    public class Taxi : Car
    {
        public Taxi(int maxSpeed) : base(maxSpeed, out int level)
        {
            Console.WriteLine(level);
        }
    }

}
