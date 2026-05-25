using System;

namespace PolymorphismHomework
{
    public class Phone : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Phone is turning on");
        }
    }
}