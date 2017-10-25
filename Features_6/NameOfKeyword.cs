using System;

namespace Features_6
{
    class NameOfKeyword
    {
        //property, degisken vs bunların string olarak adlarını almak için kolaylastıran bir keyword. 
        public int Test { get; set; }

        public NameOfKeyword()
        {
            Console.Write(nameof(this.Test) + " " + this.Test);
        }
    }

}
