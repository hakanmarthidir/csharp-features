using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_2
{
    //Sahip oldugumuz classları fiziksel olarak farklı parcalara ayırabiliriz.
    public partial class MyPartialClass
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    public partial class MyPartialClass
    {
        public void Add()
        { }
    }
    public class MyClass
    {
        public MyClass()
        {
            MyPartialClass p = new MyPartialClass();
            p.MyProperty1 = 5;
            p.Add();
        }

    }
}
