using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // The Monkey class inherits from Animal
    class Monkey : Animal
    {
        public bool ClimbsTrees { get; set; }

        // Constructor for creating monkeys
        public Monkey(string name, int age, string habitat, int numberOfLegs, bool isMammal, bool climbsTrees)
            : base(name, age, habitat, 2, true)
        {
            ClimbsTrees = climbsTrees;
        }

        // A specific method for monkeys
        public void upsideDown()
        {
            Console.WriteLine($"{Name} gillar att hänga upp och ner.");
        }

        // Overridden MakeSound method specific to monkeys
        public override void MakeSound()
        {
            Console.WriteLine($"Schimpansen {Name} skriker!");
        }
    }
}
