using System.Runtime.CompilerServices;

namespace Features_12
{
    //aim is to define the arrays which are small and with standard size, on stack without any heap allocation.
    //no GC
    //on codes which are performance critic
    //it fits well with Span<T>


    //1- Definition

    [InlineArray(10)]
    public struct MyElements
    {
        private byte _element0; //compiler manages the other elements
    }


    //2- Usage
    public class InlineArrayTest
    {

        MyElements elements = default;

        public InlineArrayTest() 
        {

            for (int i = 100; i < 110; i++)
            {
                elements[i] = (byte)i;
            }


            Span<byte> span = elements; //implicit conversion, without any allocation. you can use function like Slice, CopyTo etc. 
            Console.WriteLine(span.Length);
            Console.WriteLine(string.Join(", ", span.ToArray()));
        }    
    }
}
