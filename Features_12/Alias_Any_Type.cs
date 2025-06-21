using MyList = System.Collections.Generic.List<string>;
using Scores = int[];
using MaybeDouble = int?;
using ProductInfo = (int Id, string Name, decimal Price);
using StringDictionary = System.Collections.Generic.Dictionary<string, string>;

namespace Features_12
{
    internal class AliasAnyType
    {
        public AliasAnyType()
        {

            // you can increase readability of tuples
            ProductInfo product = (1, "Laptop", 1299.99m);
            Console.WriteLine($"{product.Name} - {product.Price:C}");


            MaybeDouble temperature = null;
            if (temperature is null)
                Console.WriteLine("Temperature could not read.");

            Scores mathScores = [85, 90, 78];
            Console.WriteLine(string.Join(", ", mathScores));

            MyList names = ["A", "B", "C"];
            StringDictionary dict = new() { ["Name"] = "H", ["Surname"] = "H" };


            //with tuple
            var inventory = new Inventory();

            inventory.AddProduct((1, "Laptop", 1299.99m));
            inventory.AddProduct((2, "Mouse", 29.99m));
            inventory.AddProduct((3, "Keyboard", 79.99m));

            inventory.PrintAll();



        }

        // with Tuple
        class Inventory
        {
            private List<ProductInfo> _products = [];

            public void AddProduct(ProductInfo p) => _products.Add(p);

            public void PrintAll()
            {
                foreach (var p in _products)
                    Console.WriteLine($"{p.Id}: {p.Name} - {p.Price:C}");
            }
        }
    }
}






