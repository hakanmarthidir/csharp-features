using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{

    public class DisposableRefStructs
    {

        public DisposableRefStructs()
        {
            using var mystruct = new DisposableStruct();

        }
    }

    //'DisposableStruct': ref structs cannot implement interfaces !!!

    //public ref struct DisposableStruct : IDisposable
    //{
    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    // So ... it works
    ref struct DisposableStruct
    {
        public void Dispose()
        {
            // no need to implementation
        }
    }

}
