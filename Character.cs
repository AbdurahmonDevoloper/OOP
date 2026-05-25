using System;

namespace PolymorphismHomework
{
    public class Character
    {
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} is attacking.");
        }
    }
}