using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PrivateProtectedSample
            //StudentName ve StudentPhoneNumber propuna erişebiliriz.
            Student x = new Student();
            x.StudentName = "";
            x.StudentPhoneNumber = "";

            //StudentName ve StudentPhoneNumber propuna erişebiliriz. 
            OldStudent oStudent = new OldStudent();
            //oStudent.StudentPhoneNumber = "";
            //oStudent.StudentName = "";

            //GiveInformation methodunu cagirdigimiz ise; 
            Console.WriteLine(oStudent.GiveInformation()); 
            #endregion

            Console.Read();
        }
    }
}
