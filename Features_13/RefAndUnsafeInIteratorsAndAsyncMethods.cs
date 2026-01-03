using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_13
{
    //Summary of this feature: Allow ref/ref struct and unsafe in code snippets that do not have yield/await.

    //Previously, in a method that used async or yield, we couldn’t use ref struct types like Span<T> or ReadOnlySpan<T>, nor ref locals at all. This was a serious limitation, especially in scenarios that require high-performance, allocation-free data processing (e.g., buffer handling or parsing). C# 13 addresses this by allowing you to use these types as long as you don’t cross an await or yield boundary, thereby maintaining a balance between safety and performance.

    internal class RefAndUnsafeInIteratorsAndAsyncMethods
    {

        //1- Span<T> in async function 
        public async Task<int> SumPrefixAsync(ReadOnlyMemory<byte> data)
        {
            // Before await : ReadOnlySpan usage is available
            ReadOnlySpan<byte> span = data.Span[..10];
            int sum = 0;
            for (int i = 0; i < span.Length; i++)
                sum += span[i];

            await Task.Delay(10); // ← barrier
            
            //var len = span.Length;
            // HERE : you can not call again the "span" -> compiler error
            // but you can call "sum"
            return sum;
        }


        //2- Iterator -> Span<T> Ref Struct usage

        public IEnumerable<int> Squares(int count)
        {
            // Managed array to keep the scores
            var tmp = new int[Math.Min(count, 16)];

            // Span will be available only in this scope, before yield block it will be closed
            {
                var span = tmp.AsSpan();
                int filled = 0;

                for (int i = 0; i < count && filled < span.Length; i++)
                {
                    span[filled++] = i * i;
                }
            } // <= span scope end

            // Now you can yield by using normal array (there is no ref struct)
            for (int i = 0; i < tmp.Length; i++)
            {
                yield return tmp[i];
            }
        }


        //3- Unsafe+yield in Iterators
        //csproj : <AllowUnsafeBlocks>true</AllowUnsafeBlocks>

        public IEnumerable<int> BytesAsInts(byte[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int val;

                // Only the reading and calculating part are "unsafe", yield will be out of this
                unsafe
                {
                    fixed (byte* p = arr)
                    {
                        val = *(p + i);
                    }
                }

                // 'yield' secure
                yield return val;
            }
        }
    }
}
