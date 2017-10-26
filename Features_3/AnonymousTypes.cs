using System;
using System.Linq;

namespace Features_3
{
    class AnonymousTypes
    {
        public AnonymousTypes()
        {
            // anon is compiled as an anonymous type
            var anon = new { Name = "Terry", Age = 34 };

            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords =
                 from w in words
                 select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
            }
        }
    }


}
