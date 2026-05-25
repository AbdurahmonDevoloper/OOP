using System;

namespace PolymorphismHomework
{
    public class Device
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Device is booting up...");
        }
    }
}