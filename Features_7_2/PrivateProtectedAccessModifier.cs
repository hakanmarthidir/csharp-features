using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    //Bazı keywordlerin kullanımını daha iyi gormek için kendi Namespaceimizdeki davranıslar ile farklı namespacelerdeki davranısları incelemek gerekir. 
    //Private Protected için de Features_7_2_Test i gozlemlemek gerekir. 
    public class Student
    {
        public string StudentName { get; set; }
        private byte StudentAge { get; set; }
        private protected string StudentAddress {get; set;}
        protected string StudentFatherName { get; set; }
        protected internal string StudentPhoneNumber { get; set; }
    }

    public class OldStudent:Student
    {        
        public OldStudent()
        {
            this.StudentName = "hakan";
            this.StudentFatherName = "michael";
            this.StudentAddress = "istanbul";
            this.StudentPhoneNumber = "555 55 55";
        }

        public string GiveInformation()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.StudentName, this.StudentFatherName, this.StudentAddress, this.StudentPhoneNumber);
        }
    }
}
