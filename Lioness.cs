using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // The Lioness class inherits from Lion
    class Lioness : Lion
    {
        public bool FeedCub { get; set; }

        // Constructor for creating lioness
        public Lioness(string name, int age, string habitat, int numberOfLegs, bool isMammal, bool feedCub)
            : base(name, age, habitat, 4, true, "kött")
        {
            FeedCub = feedCub;
        }

        // A specific method for lioness
        public void ProtectCub()
        {
            Console.WriteLine($"{Name} skyddar sin lejonunge Simba.");
        }

        // Overridden MakeSound method specific to lioness
        public override void MakeSound()
        {
            Console.WriteLine($"Lejonhonan {Name} ryter högt.");
        }
    }
}
