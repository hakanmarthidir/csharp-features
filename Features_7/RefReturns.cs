using System;

namespace Features_7
{
    class RefReturns
    {
        // Reference Return örneği
        private static ref int Substitute(int value, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == value)
                    return ref numbers[i];

            throw new IndexOutOfRangeException("Bulunamadı!");
        }

        public RefReturns()
        {
            // Referans Return
            int[] numbers = { 1, 3, 5, 7, 9, 11 };
            ref int position = ref Substitute(5, numbers);
            //5 yerine -30 yazar. 
            position = -30;
            Console.WriteLine(numbers[2]);
        }
    }
}
