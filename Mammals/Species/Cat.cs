using System;
using System.Collections.Generic;
using System.Text;

namespace EcoParkAnimalManagementSystem.Mammals.Species
{
    internal class Cat : Mammal
    {
        public Cat() {
            Name = "Olle";
            Age = 2;
            Gender = GenderType.Male;


        }
        public override string ToString()
        {
            return $"Cat -> {base.ToString()}";
        }
    }
}
