using System;
using System.Collections.Generic;
using System.Text;

namespace EcoParkAnimalManagementSystem.Mammals.Species
{
    public class Dog : Mammal
    {
        public Dog() {
            Name = "Kalle";
            Age = 1;
            Gender = GenderType.Male;
        }

        public override string ToString()
        {
            //base.ToString calls the parent class Mammal ToString( is called) method
            
     
            return $"Dog -> {base.ToString()}";
        
    }
    }
}
 