using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // The Tiger class inherits from Animal
    class Tiger : Animal
    {
        public string Breed { get; set; }

        // Constructor for creating tigers
        public Tiger(string name, int age, string habitat, int numberOfLegs, bool isMammal, string breed)
            : base(name, age, habitat, 4, true)
        {
            Breed = breed;
        }

        // A specific method for tigers
        public void jumpHigh()
        {
            Console.WriteLine("Tigern kan hoppa väldigt högt");
        }
        // Overridden MakeSound method to tigers
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} är en {Breed} och hon ryter högt!");
        }
    }
}
