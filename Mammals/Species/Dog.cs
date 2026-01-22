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
    }
}
