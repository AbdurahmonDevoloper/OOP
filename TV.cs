using System;

namespace PolymorphismHomework
{
    public class TV : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("TV is turning on");
        }
    }
}