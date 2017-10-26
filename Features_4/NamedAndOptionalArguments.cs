namespace Features_4
{
    class NamedAndOptionalArguments
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Departman { get; set; }
        public string DogumYeri { get; set; }

        //varsayılan degerleri atayabiliyoruz. 
        public NamedAndOptionalArguments(string isim, string soyisim, string departman = "N/A", string dogumyeri = "")
        {

        }
    }

    class XYZ
    {
        public XYZ()
        {
            //Named Arguments - isme gore atama
            var x = new NamedAndOptionalArguments("", "", dogumyeri: "");
        }
    }
}
