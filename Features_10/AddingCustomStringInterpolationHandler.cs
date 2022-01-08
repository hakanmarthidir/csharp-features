using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    //Interpolated String Improvements
    // you can create your customized string interpolated handler with InterpolatedStringHandler attribute. 
    //for example in logger string strategies 

    //class or struct 

    [InterpolatedStringHandler]
    public ref struct AddingCustomStringInterpolationHandler
    {
        StringBuilder builder;
        public AddingCustomStringInterpolationHandler(int literalLength, int formattedCount)
        {
            this.builder = new StringBuilder(literalLength);
        }

        public void AppendLiteral(string s)
        {
            // Store and format part as required
            //...
            builder.Append(s);
        }

        public void AppendFormatted<T>(T t)
        {
            // Store and format part as required
            //...
            this.builder.Append(t?.ToString());
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
