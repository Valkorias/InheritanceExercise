using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Legs = 2;
            HasTail = true;
            CanSee = true;
        }

        public bool IsColdBlooded { get; set; } = true;
        public string Agility { get; set; } = "Deft";
        public bool AdvancedRegeneration { get; set; } = true;
        public bool CanChangeColor { get; set; } = true;

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Is Cold-Blooded: {IsColdBlooded}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Has Advanced Regeneration: {AdvancedRegeneration}");
            Console.WriteLine($"Can Change Color: {CanChangeColor}");
        }

    }
}
