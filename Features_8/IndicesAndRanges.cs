using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public class IndicesAndRanges
    {

        public IndicesAndRanges()
        {
            var cities = new string[] { "Stuttgart", "Esslingen", "Cologne", "Frankfurt", "Hamburg", "Munchen", "Berlin" };

            Console.WriteLine(cities[0]); //Stuttgart
            Console.WriteLine(cities[^1]); //Berlin

            var allCities = cities[..];
            var limitedCities1 = cities[..3];
            var limitedCities2 = cities[3..];
            var limitedCities3 = cities[1..5]; // index 5 is not included
            var limitedCities4 = cities[^3..^0];

            WriteToConsole(allCities);
            WriteToConsole(limitedCities1);
            WriteToConsole(limitedCities2);
            WriteToConsole(limitedCities3);
            WriteToConsole(limitedCities4);

            static void WriteToConsole(string[] cityArray) {
                foreach (var item in cityArray)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}
