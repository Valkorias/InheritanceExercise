using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animal
    {
        public Birds()
        {
            IsAlive = true;
            Legs = 2;
            HasTail = true;
            CanSee = true;
        }

        public bool HasFeathers { get; set; }
        public bool HasBeak { get; set; }
        public bool HasTalons { get; set; }
        public bool CanFly { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Unique Mouth: {HasBeak} : Beak");
            Console.WriteLine($"Unique Claws: {HasTalons} : Avian Weaponry");
        }
    }
}
