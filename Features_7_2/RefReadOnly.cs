using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    public class RefReadOnly
    {
        //Referans bir deger tipi elde etmek istiyoruz ancak bunun degistirilmesini de istemiyorsak kullanabilecegimiz bir yontemdir. 
        private static string filePath = "";
        public static ref readonly string Path => ref filePath;
    }    

    public class RefReadOnlyTest
    {
        public RefReadOnlyTest()
        {
            //1- Asagidaki gibi bir denemede ReadOnly prop oldugu için degistirilemez hatası alırız. 
            //RefReadOnly.Path = "asdasdas";                      
            string myFilePath = RefReadOnly.Path;
        }
    }
}


