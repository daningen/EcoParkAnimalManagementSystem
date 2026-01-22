using EcoParkAnimalManagementSystem.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoParkAnimalManagementSystem
{
   //inherits Animal
   public class Mammal : Animal
    {
        private CategoryType CategoryType;

        public Mammal() { 
        CategoryType = CategoryType.Mammal;

        }
        public override string ToString()
        {
            //base.ToString calls the parent class Animal ToString( is called) method
            //Category is added here in Mammal class from default CategoryType set in Mammal constructor
            return $"{base.ToString()}, Category: {CategoryType}";
        }

    } 
}
