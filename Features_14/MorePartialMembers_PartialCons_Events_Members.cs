using System;
using System.Collections.Generic;
using System.Text;

namespace Features_14
{
    internal class MorePartialMembers_PartialCons_Events_Members
    {
        //1- Partial Constructor
        public partial class User
        {
            //only constructor signature, no implementation
            public partial User(string name); 
        }

        public partial class User
        {
            public string Name { get; }
            //implementation of partial constructor
            public partial User(string name)
            {
                Name = (name ?? throw new ArgumentNullException(nameof(name))).Trim();
            }
        }


        //2- Inheritance + Initializer

        public class Person(string name) { public string Name { get; } = name; }

        public partial class Customer : Person
        {
            public partial Customer(string name); // base(...) you can not write base here
        }

        public partial class Customer
        {
            public partial Customer(string name) : base(name) // initializer 
            {
                //codes...
            }
        }


        //3- Partial Event

        public partial class Service
        {
            public partial event EventHandler? Changed; // field-like
        }
        public partial class Service
        {
            private EventHandler? _changed;

            public partial event EventHandler? Changed
            {
                add { Console.WriteLine("Subscribed"); _changed += value; }
                remove { Console.WriteLine("Unsubscribed"); _changed -= value; }
            }

            protected void RaiseChanged() => _changed?.Invoke(this, EventArgs.Empty);
        }

    }
}
