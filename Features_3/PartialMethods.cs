using System;

namespace Features_3
{
    partial class PartialMethods
    {
        //bir tarafta tanımlaması bir tarafta ise implemente edilmis hali olabilir. Partial classlarla ilişkilidir.
        partial void Calculate();
    }

    partial class PartialMethods
    {
        //void olmalıdır. 
        partial void Calculate() { Console.WriteLine(""); }
    }
}
