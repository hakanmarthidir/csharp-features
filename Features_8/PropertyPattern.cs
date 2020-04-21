using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{

    public enum BahnRegions
    {
        Region1,
        Region2,
        Region3
    }

    public class Student
    {
        public string Name { get; set; }
        public BahnRegions BahnRegion { get; set; }
    }

    //Propertynin aldıgı degere gore eylemler  gerceklestirmek için kullanılabilir. Yeni switch expressionından yararlanarak yazmak daha kolay.
    public class PropertyPattern
    {
        public static decimal Calculate(Student student, decimal standardPrice) => student switch
        {
            { BahnRegion: BahnRegions.Region1 } => standardPrice,
            { BahnRegion: BahnRegions.Region2 } => standardPrice + 5,
            { BahnRegion: BahnRegions.Region3 } => standardPrice + 10,
            _ => standardPrice
        };

    }
}
