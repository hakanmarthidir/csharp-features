using System;
namespace Features_9
{
    public static class PatternMatchingEnhancements
    {
        //or and is - logical patterns
        public static string CheckPageCount(BookInit bookInit) => bookInit.PageCount switch
        {
            0 or 1 => "Empty",
            < 100 => "Short Book",
            > 100 and < 300 => "Mid Book",
            _ => "Thick Book"
        };

        public static double GetBookPrice(BookInit bookInit)
        {
            // is / is not null
            if (bookInit is not null)
                return bookInit.Price;

            return 0;
        }
        //or
        public static double GetBookPrice2(BookInit bookInit) => bookInit is not null ? bookInit.Price : 0;

        public static bool IsExpensive(this BookInit c) => c.Price is (>= 30 and <= 50) or (>= 50 and <= 100);

    }
}
