using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_11
{
   
    public class XFilter { }
    public class YFilter { }

    // type safety...
    // performance : no more runtime check
    // you can get build time error
    // code completion
    // object, string, ValueTuple<int,int> you can use them.
    // dynamic, string? and (int x, int y) not allowed
    public class ValidateFilter<T> : Attribute where T : class
    {
        public T FilterType { get; set; }
       
    }

    public class NotificationService
    {

        [ValidateFilter<string>]
        public void MyOperation()
        {
        }

        //[SendMessage<T>] -> Not Allowed with <T>
        [ValidateFilter<XFilter>()]
        public void MyOperation2()
        {
        }

        [ValidateFilter<YFilter>()]
        public void MyOperation3()
        {
        }
    }


}
