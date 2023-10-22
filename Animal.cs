using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Base class Animal
    class Animal
    {
        // Properties shared by all animals
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }

        // Constructor for creating new animals
        public Animal(string name, int age, string habitat, int numberOfLegs, bool isMammal)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            NumberOfLegs = numberOfLegs;
            IsMammal = isMammal;
        }

        // Common methods for all animals
        public void Eat()
        {
            Console.WriteLine($"{Name} äter sin mat.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sover så gott.");
        }

        // A virtual method that all animals can override to make their own sounds
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} gör ett generellt djurläte");
        }
    }
}
