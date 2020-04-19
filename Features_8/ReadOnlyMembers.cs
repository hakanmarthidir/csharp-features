using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public struct ReadOnlyMembers
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string Fullname => string.Concat(this.Name, " ", this.Surname);

        public readonly string GiveFullName() {
            return this.Fullname.ToLower();
        }
    }
}
