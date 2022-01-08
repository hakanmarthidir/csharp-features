using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    public struct ParameterlessStructConstructor
    {
        public string Name { get; set; } = string.Empty;
        public ParameterlessStructConstructor()
        {
            //parameterless constructor, you can define with c#10, not possible in c#9
        }
        public ParameterlessStructConstructor(string name)
        {
            this.Name = name;
        }

    }
}
