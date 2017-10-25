namespace Features_7_1
{
    public class PatternMatchingWithGenerics
    {
        public enum Breed
        {
            LabradorRetriever
        }

        public class Animal { }

        public class Dog : Animal
        {
            public Breed Breed { get; }
        }

        public void Interact<TAnimal>(TAnimal animal) where TAnimal : Animal
        {
            //if (animal is Dog dog)
            //{
            //    
            //}

            switch (animal)
            {
                case Dog dog when (dog.Breed == Breed.LabradorRetriever):
                    
                    break;
            }
        }
    }
}
