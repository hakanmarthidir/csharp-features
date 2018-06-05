using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    //Bellek yonetimi yeteneklerinden biri de ref structtır. 
    //Bu tip özellikler sıklıkla karsılasacagımız yapılardan degildir ancak performans ihtiyacları soz konusu oldugunda tekrar gozden gecirmede yardımcı olabilirler. 
    ref struct RefStructType
    {
    }
    struct NonRefStructType
    {
    }

    class RefStructTest
    {
        //1- ref struct yapıları bir classın veya refsiz tanımlanmıs bir structun uyesi olamaz. 
        //public RefStructType MyType { get; set; }
        public NonRefStructType MyProperty { get; set; }

        public RefStructTest()
        {
            //2- ref olarak işaretlenmemis bir struct object veya dynamic tipe atanabilir. 
            NonRefStructType n = new NonRefStructType();
            object no = n;
            dynamic c = n;

            //**ref olarak belirtilmiş bir struct ise atanamaz.. 
            RefStructType r = new RefStructType();
            //Error
            //object o = r;
            //dynamic d = r;

        }
    }
}
