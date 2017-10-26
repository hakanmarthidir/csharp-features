using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_2
{
    public class Person
    {
        public string LastName = string.Empty;
        public string FirstName = string.Empty;
        public DateTime DateOfBirth;

        public Person()
        {
        }
    }

    class AnonymousMethods
    {
        //Anonim methodlar, bir delege nesnesinin kabul edilebilir olduğu bir kod bloğu tanımlamamızı sağlar.
        //Delegate tanımlandıktan sonra o delegenin temsil edecegi methodda ayrı olarak belirtilir ve method içerisinde calisması gereken kodlar yazılırdı. 
        //bu sekilde ise sanki oyle bir method varmıs gibi davranan sistem kendisine belirtilen işi yapabilir. 

        //anonymous methodlar her zaman delegate anahtar kelimesi ile baslar.
        //
        public AnonymousMethods()
        {
            List<Person> people = new List<Person>();

            Person teacher = new Person();
            teacher.LastName = "Smith";
            teacher.FirstName = "Joe";
            teacher.DateOfBirth = new DateTime(1959, 12, 20);
            people.Add(teacher);

            Person doctor = new Person();
            doctor.LastName = "Williams";
            doctor.FirstName = "Mary";
            doctor.DateOfBirth = new DateTime(1973, 5, 5);
            people.Add(doctor);

            Person lawyer = new Person();
            lawyer.LastName = "Jones";
            lawyer.FirstName = "Tom";
            lawyer.DateOfBirth = new DateTime(1966, 3, 15);
            people.Add(lawyer);

            people.ForEach(delegate (Person a)
            {
                Console.WriteLine(string.Format("{0} {1}", a.FirstName, a.LastName));
            });
        }
    }

    //Normal Kullanımı
    class OldDelegateSample
    {
        //delegate tanımlanır.
        delegate void Del(string str);

        //Delegatee uygun bir method. yada tam tersi methoda gore bir delegate
        static void Notify(string name)
        {
            Console.WriteLine("Notification received for: {0}", name);
        }

        public OldDelegateSample()
        {
            //calistirma sekilleri
            Del del1 = new Del(Notify);
            Del del2 = Notify;
            //veya anonymous methods ile 
            Del del3 = delegate (string name) { Console.WriteLine("Notification received for: {0}", name); };

        }

    }
}
