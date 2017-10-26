using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_2
{
    public class Generics_Feature
    {
        //Dısarıdan aldıgı degere gore kendisini ozellestiren yapılardır. Classlarda, interfacelerde,
        //listelerde vs. kullanılabilir. 
    }
    public class MySample<T>
    {
        List<T> list;
        public MySample()
        {
            list = new List<T>();
        }
        public void AddItem(T item)
        {
            list.Add(item);
        }
    }
}
