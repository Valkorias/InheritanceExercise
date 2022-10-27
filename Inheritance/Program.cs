using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Birds()
            {
                HasFeathers = true,
                CanFly = true,
                HasBeak = true,
                HasTalons = true,
            };

            var leopard_gecko = new Reptile()
            {
                Legs = 4,
                CanChangeColor = true,
                AdvancedRegeneration = true,
            };

            bird.PrintDetails();
            
            leopard_gecko.PrintDetails();
        }
    }
}
