using static System.String;

namespace Features_6
{
    class UsingStatic
    {
        //using bolumune eklenir. 
        //using static System.String;
        public string MyProperty { get; set; }
        public UsingStatic()
        {
            if (IsNullOrEmpty(MyProperty))
            {
                //do something
            }
        }
    }

}
