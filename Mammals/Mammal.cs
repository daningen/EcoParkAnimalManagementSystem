using EcoParkAnimalManagementSystem.AnimalsGen;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoParkAnimalManagementSystem
{
   //inherit Animal
   public class Mammal : Animal
    {
        private CategoryType CategoryType;

        public Mammal() { 
        CategoryType = CategoryType.Mammal;

        }
    }
}
