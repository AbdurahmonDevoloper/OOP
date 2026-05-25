using System;

namespace PolymorphismHomework
{
    public class TelegramNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending notification via Telegram: New message in bot.");
        }
    }
}