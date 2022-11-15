using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Features_11
{
    internal class Utf8StringLiteral
    {
        public Utf8StringLiteral()
        {
            //INFO : Strings in .NET are stored using UTF-16 encoding.
            //u8 suffix
            ReadOnlySpan<byte> ut8Text = "ŞiğülewsçöÖ"u8;
            byte[] textArray = ut8Text.ToArray();
           

        }
    }
}
