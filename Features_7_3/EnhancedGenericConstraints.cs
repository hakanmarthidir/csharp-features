using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{

    //Generic Constaints
    //Bu geliştirme ile birlikte artık Enum, Delegate gibi yapıları kullanabiliyoruz. 
    //bunlara ek olarak unmanaged constrainiti de kullanıp unmanaged tipler için kullanabiliriz. 

    // Generic constraintler -> where T : struct, class, notnull, unmanaged, new(), <baseclassname>, <interfacename>, U olabilir. 

    // Ornegin -> Class
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }

    public class StudentList<T> where T : Student
    {
        public void AddStudent(T student) { }
    }


    // Ornegin -> Enum

    public static class MyEnumExtensions
    {
        public static string EnumManager<TEnum>(this Enum myenum) where TEnum : Enum
        {
            // codes ...
            return string.Empty;
        }
    }

    // Ornegin -> Delegate

    public class MyDelegateClass<T> where T : Delegate
    {
        public void DelegateManager(T dlg)
        {
            // codes ...
        }
    }

    // Ornegin -> UnManaged
    public class MyGenericUnManagedClass<T> where T : unmanaged
    {
        unsafe public static byte[] UnManagedMethod(T unmanagedvariable)
        {
            // codes ...
            return null;
        }

        Span<int> UnManagedMethod2<T>(in T value) where T : unmanaged
        {
            // codes ...
            return null;
        }

    }
    
}
