namespace Features_11
{
    public class StaticAbstractVirtualMethods
    {

        public void Iterate()
        {
            var item = new MyNextItem { Value = 1 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(item++);
            }
        }
    }


    public interface IGetNext<T> where T : IGetNext<T>
    {
        static abstract T operator ++(T other);
    }

    public struct MyNextItem : IGetNext<MyNextItem>
    {
        public double Value { get; set; }
        public static MyNextItem operator ++(MyNextItem other)
        {
            return other with { Value = other.Value * 2 };
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }

}
