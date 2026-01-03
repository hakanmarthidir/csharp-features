using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_13
{
    internal class ImplicitIndexAccess
    {
        public ImplicitIndexAccess()
        {
            var words = new[] { "first", "second", "third", "fourth", "fifth" };

            var last = words[^1]; // "fifth"
            var beforeLast = words[^2]; // "fourth"




            //with C#13 you can use this for the assignemnts

            var list = new List<int>(new int[5])
            {
                [^1] = 0,
                [^2] = 1,
                [^3] = 2,
                [^4] = 3,
                [^5] = 4
            };
            // Result: [4, 3, 2, 1, 0]



            var holder = new BufferHolder
            {
                Buffer =
                {
                    [^1] = 42,  // as last item -> 42
                    [^2] = 37,  // second to last 37
                    [^3] = 29,  // third to last 29
                    [^4] = 18   // fourth to last it means as first item 18
                }
            };

            // holder.Buffer: [18, 29, 37, 42]

        }
    }

    public class BufferHolder
    {
        public int[] Buffer { get; set; } = new int[4];
    }

}
