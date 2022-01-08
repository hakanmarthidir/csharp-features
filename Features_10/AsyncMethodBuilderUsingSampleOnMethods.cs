using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    public class AsyncMethodBuilderUsingSampleOnMethods
    {
        //before c# 10 , we could not use this attribute on methods before. 
        //only it was valid on class, struct, delegate, interface, enum
        //with c# 10 we are able to use 

        //[AsyncMethodBuilder(typeof(AsyncMethodBuilderUsingSampleOnMethods))]
        public async Task GetTaskAsync() { }
    }


}
