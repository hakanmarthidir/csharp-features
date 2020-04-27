using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public struct UnmanagedConstructedTypes<T>
    {
        public T MyFirstVariable;
    }

    public class UnManagedConstructedManager
    {
        public UnManagedConstructedManager()
        {
            Span<UnmanagedConstructedTypes<char>> myChars = stackalloc[] {
                new UnmanagedConstructedTypes<char> { MyFirstVariable = 'H' },
                new UnmanagedConstructedTypes<char> { MyFirstVariable = 'A' },
                new UnmanagedConstructedTypes<char> { MyFirstVariable = 'K' },
                new UnmanagedConstructedTypes<char> { MyFirstVariable = 'A' },
                new UnmanagedConstructedTypes<char> { MyFirstVariable = 'N' }
            };
        }

    }

}
