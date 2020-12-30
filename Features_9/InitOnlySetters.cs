using System;
namespace Features_9
{
    //class or record, it does not matter...
    public record BookInit
    {
        //you can set this value only in constructor or when you initialize this, after that it will be read only
        public string ISBN { get; init; }
        public string BookName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }

    }




}
