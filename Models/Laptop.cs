using System;

namespace PolymorphismHomework
{
    public class Laptop : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Laptop is turning on");
        }
    }
}