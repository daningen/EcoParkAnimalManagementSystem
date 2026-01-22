using EcoParkAnimalManagementSystem.Mammals.Species;
using System;

namespace EcoParkAnimalManagementSystem 
{
    public class Public
    {
    public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog);
            Console.WriteLine("EcoPark tjoho Animal Management System 1");
            // Console.ReadLine();
            //overwrite name from Dog constructor
            dog.Name ="Buddy";
            Console.WriteLine($"Dog's name is: {dog.Name}");
        }
    }
}


