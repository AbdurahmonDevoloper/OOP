using System;

namespace PolymorphismHomework
{
    public class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("Sending a general notification.");
        }
    }
}