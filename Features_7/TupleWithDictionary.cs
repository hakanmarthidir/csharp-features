using System.Collections.Generic;

namespace Features_7
{
    class TupleWithDictionary
    {
        public TupleWithDictionary()
        {
            var tupleDictionary = new Dictionary<(int, int), string>();
            tupleDictionary.Add((16, 21), "İki kardeşin yaşları");

            // Sonuç = İki kardeşin yaşları
            var result = tupleDictionary[(16, 21)];
        }
    }
}
