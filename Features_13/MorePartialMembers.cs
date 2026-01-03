using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_13
{
    internal class MorePartialMembers
    {
        //C#12 and previous versions : there was no partial property or indexers. properties and indexers had to be in same partial class. 
        //for example: 
        public partial class ExCustomer
        {
            // Property in one-place; logic must be here
            public string Name
            {
                get => _name?.Trim();
                set => _name = value ?? string.Empty;
            }

            private string _name;
        }

        //with C#13 ->
        //Partial properties and indexers are now allowed in partial types
        //Defining Declaration and 
        //Implementing Declaration

        //Sample for Properties
        public partial class Customer
        {
            // Definition: no body, only contract
            public partial string Name { get; set; }
        }


        public partial class Customer
        {
            private string _name;

            // Implementation: real getter/setter
            public partial string Name
            {
                get => _name?.Trim();
                set => _name = value ?? string.Empty;
            }
        }

        //--------------------------------------

        //Sample for Indexers
        public partial class DataStore
        {
            // Definition: indexer announcement, no body
            public partial int this[int index] { get; set; }
        }

        public partial class DataStore
        {
            private readonly int[] _data = new int[10];

            public partial int this[int index]
            {
                get => _data[index];
                set => _data[index] = value;
            }
        }



    }
}
