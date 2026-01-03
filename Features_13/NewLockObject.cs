using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Features_13
{
    public class NewLockObject
    {
        //original lock keyword was working with Monitor bases.

        //a new lock keyword was generated. 
        //System.Threading.Lock
        //uses EnterScope() and Dispose() 

        //reasons : 
        //performance 
        //low overhead

        private readonly object _sync;

        public NewLockObject()
        {
            //Previously 
            lock (_sync)
            {
            }               
        }


        //New Lock Definition

        private readonly Lock _lock1 = new();
        private readonly Lock _lock2 = new();

        public void Lock()
        {
            lock (_lock1) // Compiler: using (_lock.EnterScope()) { ... }
            {               
                //TestAsync -> X cant use 
            }

        }

        public async Task TestAsync()
        { 
        }

        //or manually you can manage
        public void LockManual()
        {         
            using var scoper = _lock2.EnterScope();
            //after dispose, it will be free.        
        }

        //Prefer this instead of old fashioned way, it uses less CPU/GC loads
        //if you need a performant way, you can use it 
        //both way are always sync lock, you cant use await inside.

    }
}
