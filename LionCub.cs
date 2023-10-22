using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    // The LionCub class inherits from Lion
    class LionCub : Lion
    {
        public bool Nursing { get; set; }

        // Constructor for creating lioncubs
        public LionCub(string name, int age, string habitat, int numberOfLegs, bool isMammal, bool nursing)
            : base(name, age, habitat, 4, true, "mjölk")
        {
            Nursing = nursing;
        }

        // A specific method for lioncubs
        public void Play()
        {
            Console.WriteLine($"{Name} leker med andra lejonungar.");
        }

        // Overridden MakeSound method specific to lioncubs
        public override void MakeSound()
        {
            Console.WriteLine($"Lejonungen {Name} gör små söta ljud.");
        }
    }
}
