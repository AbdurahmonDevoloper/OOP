using System;

namespace PolymorphismHomework
{
    public class Archer : Character
    {
        public Archer(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots arrow");
        }
    }
}