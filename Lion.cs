using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // The Lion class inherits from Animal
    class Lion : Animal
    {
        public string MainFood { get; set; }

        // Constructor for creating lions
        public Lion(string name, int age, string habitat, int numberOfLegs, bool isMammal, string mainFood)
            : base(name, age, habitat, 4, true)
        {
            MainFood = mainFood;
        }

        // A specific method for lions
        public void Hunt()
        {
            Console.WriteLine($"{Name} jagar andra djur för att kunna äta deras {MainFood}.");
        }

        // Overridden MakeSound method specific to lions
        public override void MakeSound()
        {
            Console.WriteLine($"Lejonet {Name} vrålar högt och kraftfullt för att visa vem som bestämmer!");
        }
    }
}
