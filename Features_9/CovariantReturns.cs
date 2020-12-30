using System;
namespace Features_9
{
    public class Order { }
    public class LaptopOrder : Order { }
    public class WatchOrder : Order { }
    public class AppOrder : Order { }

    public abstract class Product
    {
        protected string Brand { get; set; }
        protected string ModelName { get; set; }
        protected int ModelYear { get; set; }

        protected Product(string brand, string model, int year) => (Brand, ModelName, ModelYear) = (brand, model, year);

        public abstract Order CreateOrder();
    }


    public class Macbook : Product
    {
        public bool IsRetina { get; set; }
        public Macbook(string brand, string model, int year, bool isRetina) : base(brand, model, year)
        {
            this.IsRetina = isRetina;
        }

        //you can change the return value of abstract method after override. 
        public override LaptopOrder CreateOrder()
        {
            return new();
        }
    }

    public class AppleWatch : Product
    {
        public double Inch { get; set; }
        public AppleWatch(string brand, string model, int year, double inches) : base(brand, model, year)
        {
            this.Inch = inches;
        }

        public override WatchOrder CreateOrder()
        {
            return new();
        }
    }

}
