using System;

namespace Features_7_1
{
    public class DefaultExpressions
    {
        //Compilerin default degeri vererek yola devam etmesini saglar. 
        public DefaultExpressions()
        {
            var number = default(int);      // 0
            var date = default(DateTime);   // DateTime.MinValue
            var obj = default(object);      // null
            int number2 = default;   // 0
            Guid guid = default; // 00000000-0000-0000-0000-000000000000
            bool lucky = default;

            var number3 = lucky ? 7 : default;
        }

        public int Sum(params int[] numbers)
        {
            if (numbers.Length == default)
            {
                return default; // Returns 0
            }
            return 23;
        }


    }
}
