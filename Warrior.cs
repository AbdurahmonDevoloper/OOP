using System;

namespace PolymorphismHomework
{
    public class Warrior : Character
    {
        // Parent klassda konstruktor bo'lgani uchun : base(name) orqali unga nom uzatamiz
        public Warrior(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with sword");
        }
    }
}