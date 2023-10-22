using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // The Gorilla class inherits from Monkey
    class Gorilla : Monkey
    {
        public bool ChestPounding { get; set; }

        // Constructor for creating gorillas
        public Gorilla(string name, int age, string habitat, int numberOfLegs, bool isMammal, bool chestPounding)
            : base(name, age, habitat, 2, true, true)
        {
            ChestPounding = chestPounding;
        }

        // A specific method for gorilla
        public void Hugs()
        {
            Console.WriteLine($"{Name} älskar att kramas, han kan dock vara lite hårdhänt ibland!");
        }
        // Overridden MakeSound method specific to gorillas
        public override void MakeSound()
        {
            Console.WriteLine($"Gorillan {Name} ryter för att visa dominans i gruppen!");
        }
    }
}