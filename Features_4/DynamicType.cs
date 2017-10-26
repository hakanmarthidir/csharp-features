using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Features_4
{    
    public class Coffee
    {
        public int GetZing()
        {
            return 1;
        }
    }
    public class Juice
    {
        public string GetZing()
        {
            return "Orange";
        }
    }
    public class DynamicType
    {
        public DynamicType()
        {
            //Runtime da ilgili tiplere donusecek degiskenler anlamına geliyor. 
            dynamic drink = GetOneOfThem(1);
            Console.WriteLine(drink.GetZing());

            //ExpandObject -> runtime da dinamik olarak eleman ekleyebiliyor. 
            dynamic d = new ExpandoObject();
            IDictionary<string, object> members = d as IDictionary<string, object>;
            members.Add("Foo", "foo");
            members.Add("Bar", 4);

            Console.WriteLine("Foo=" + d.Foo);
            Console.WriteLine("Bar=" + d.Bar.ToString());
        }


        private static Object GetOneOfThem(int i)
        {
            if (i > 10)
            {
                return new Juice();
            }
            else
            {
                return new Coffee();
            }
        }
    }
}
