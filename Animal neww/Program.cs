using System;

namespace Animal_neww
{
    class Program
    {
        static void Main(string[] args)
        {
         



            var dog = new Dog("Amigo","White","Maltese",2,"gav");
            
            Console.WriteLine(dog.GetVoice());



            var cat = new Cat("Tom", "Black", "Syamskiy", 1, "myau");
            Console.WriteLine(cat.GetVoice());

        }
    }
}
