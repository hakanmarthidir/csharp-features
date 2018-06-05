using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{    
    //Bu tip readonly structları yaratırken degerlerinizi sadece Constructor uzerinden atayabilirsiniz. 
    readonly struct MyReadOnlyStruct
    {
        public string Name { get;  }
        public string Surname { get; }

        public MyReadOnlyStruct(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }

    class ReadOnlyStructTest
    {
        public ReadOnlyStructTest()
        {
            MyReadOnlyStruct ms = new MyReadOnlyStruct("asda", "sdfgdfg");
            //proplara atama yapıldı, sonrasında degistirilmek istendiginde asagidaki kod hata alacaktır.
            //ms.Name = "asdsdffdgdfg";
        }
    }

}
