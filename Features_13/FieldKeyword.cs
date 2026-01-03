using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_13
{
    internal class FieldKeyword
    {
        public class Legacy
        {
            private string _name;
            public string Name
            {
                get => _name;
                set => _name = value?.Trim();
            }
        }


        //this new "field" keyword actually provides to access the backing field of auto-property. 
        //public int X {get;set;}  -> auto-property

        // you can not access directly, if you want to add some logics there, you need to add full property definition. 
        //but with this keyword you can access and add your codes for validation, normalization or restrictions. 

        //to activate -> go to csproj and change LangVersion
        //<LangVersion>preview</LangVersion>


        public class Person
        {
            // Auto-property: backing field automatic
            public string Name
            {
                get => field;
                set => field = value?.Trim() ?? "";
            }
        }

        public class Settings
        {            
            public int BufferSize
            {
                get => field < 1024 ? 1024 : field;
                set => field = value < 0 ? 0 : value;
            }
        }

        public class Report
        {
            public DateTime Date
            {
                get => field;
                set => field = value < DateTime.Today ? DateTime.Today : value;
            }
        }

        public class Product
        {
            public decimal Price
            {
                get => field;
                init => field = Price < 0 ? 0 : Price;
            }
        }
    }
}
