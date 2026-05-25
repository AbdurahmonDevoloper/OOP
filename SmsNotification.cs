using System;

namespace PolymorphismHomework
{
    public class SmsNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending notification via SMS: Code sent to your phone.");
        }
    }
}