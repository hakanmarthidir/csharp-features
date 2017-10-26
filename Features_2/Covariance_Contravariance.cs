using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_2
{
    //Covariance ve Contravariance sadece reference tipleri destekler. 
    //Implicit reference donusumlerini saglamak ve geri dondurmek için kullanılırlar. 
    //arrayler, delegateler ve generic tiplerde kullanılırlar. 
    //covariance atama uyumlulugunu saglar, contravariance geri alır. 

    public abstract class Animal
    {
        public string Name { get; set; }
    }
    public class Cat : Animal
    {
        public Cat(string name)
        {
            this.Name = name;
        }
    }

    class Covariance
    {
        //Covariance
        //Base typein beklendigi yere turetilmis class verebilmektir. 

        public Covariance()
        {
            //IEnumerable bir yapıya dondugumuzde sadece okumak uzere tasarlanmıs bir liste ile karsılasırız.
            //Read-Only
            IEnumerable<Cat> cats = new List<Cat> { new Cat("Troublemaker") };
            //Turetilmis classı verebiliyoruz. 
            PrintAnimals(cats);
        }

        //Base class bekliyor
        void PrintAnimals(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
    class Contravariance
    {
        public Contravariance()
        {
            //WriteOnly
            //IComparator<Animal> compareAnimals = new AnimalSizeComparator();
            //CompareCats(compareAnimals);
        }

        void CompareCats(IComparer<Cat> comparer)
        {
            var cat1 = new Cat("Otto");
            var cat2 = new Cat("Troublemaker");
            if (comparer.Compare(cat2, cat1) > 0)
                Console.WriteLine("Troublemaker wins!");
        }
    }

    //Other Samples
    class Small
    {

    }
    class Big : Small
    {

    }
    class Bigger : Big
    {

    }

    class CovarianceWithDelegate
    {
        public delegate Small covarDel(Big mc);

        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        public CovarianceWithDelegate()
        {
            covarDel del = Method1;
            Small sm = del(new Big());
        }


    }

    class ContravarianceWithDelegate
    {
        delegate Small covarDel(Big mc);

        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }
        static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");
            return new Small();
        }

        public ContravarianceWithDelegate()
        {
            covarDel del = Method1;
            del += Method2;
            del += Method3;

            Small sm = del(new Big());
        }

    }
}
