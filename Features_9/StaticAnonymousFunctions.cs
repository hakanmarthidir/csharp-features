using System;
using System.Collections.Generic;

namespace Features_9
{
    public class StaticAnonymousFunctions
    {
        const string stringFormat = "{0}";

        public StaticAnonymousFunctions()
        {
            ShowNextMatches(static match => string.Format(stringFormat, match));
        }

        //Design Rules :https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/static-anonymous-functions
        void ShowNextMatches(Func<string, string> func)
        {
            var matchList = new List<string> { "New York - Boston", "Chicago Bulls - LA Lakers", "Brooklyn - Minnesota" };

            foreach (var match in matchList)
                Console.WriteLine(func(match));
        }

    }
}
