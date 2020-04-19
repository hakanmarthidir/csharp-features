using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{

    //OLD BEHAIVOR
    [Serializable]
    class AttributesToFields_Old
    {
        [NonSerialized] //burası gecerli bir nokta
        private int myVar;
        // [NonSerialized] -> Burada kullanmazdınız ancak degiskenin basında kullanabilirdiniz. 
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }


    //7.3 BEHAIVOR 

    [Serializable]
    class AttributesToFields
    {
        //Simdi ise asagidaki sekilde kullanımı mümkündür. Auto propertylerde buna imkan verildi.
        [field : NonSerialized]
        public int MyProperty { get; set; }

        public delegate void MyPropertyEventHandler();
        [field: NonSerialized]
        public event MyPropertyEventHandler MyPropertyUpdated;
        
    }




}
