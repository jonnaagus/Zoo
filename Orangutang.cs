using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // The Orangutang class inherits from Monkey
    class Orangutang : Monkey
    {
        public bool Laughs { get; set; }

        // Constructor for creating orangutangs
        public Orangutang(string name, int age, string habitat, int numberOfLegs, bool isMammal, bool laughs)
            : base(name, age, habitat, 2, true, true)
        {
            Laughs = laughs;
        }
        // A specific method for orangutang
        public void Goofing()
        {
            Console.WriteLine($"Orangutangen {Name} älskar att leka, busa och skämta med sina kompisar.");
        }
        // Overridden MakeSound method specific to orangutang
        public override void MakeSound()
        {
            Console.WriteLine($"Orangutangen {Name} gör ett smackande ljud med läpparna!");
        }
    }
}
