using System;

namespace PolymorphismHomework
{
    public class EmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending notification via Email: Check your inbox!");
        }
    }
}