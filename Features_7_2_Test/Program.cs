using Features_7_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    
    //Private Protected Access Modifierini Test Edebilmek için Olusturuldu. 
    public class NewStudent : Student
    {
        public NewStudent()
        {
            this.StudentFatherName = "";
            this.StudentName = "";
            this.StudentPhoneNumber = "";           
            //StudentAddress propertysine erişemeyiz. Farklı bir namespace de private a burunuyor. 
        }
    }
}
