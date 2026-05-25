using System;

namespace PolymorphismHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // 1-TASK — Shape System
            // ==========================================
            Console.WriteLine("--- TASK 1: Shape System ---");
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();
            Shape s3 = new Triangle();

            s1.Draw();
            s2.Draw();
            s3.Draw();
            Console.WriteLine();

            // ==========================================
            // 2-TASK — Notification System
            // ==========================================
            Console.WriteLine("--- TASK 2: Notification System ---");
            Notification n1 = new EmailNotification();
            Notification n2 = new SmsNotification();
            Notification n3 = new TelegramNotification();

            n1.Send();
            n2.Send();
            n3.Send();
            Console.WriteLine();

            // ==========================================
            // 3-TASK — Payment System
            // ==========================================
            Console.WriteLine("--- TASK 3: Payment System ---");
            Payment p1 = new ClickPayment();
            Payment p2 = new PaymePayment();
            Payment p3 = new CashPayment();

            p1.Pay();
            p2.Pay();
            p3.Pay();
            Console.WriteLine();

            // ==========================================
            // 4-TASK — Game Characters
            // ==========================================
            Console.WriteLine("--- TASK 4: Game Characters ---");
            Character c1 = new Warrior("Warrior");
            Character c2 = new Archer("Archer");
            Character c3 = new Mage("Mage");

            c1.Attack();
            c2.Attack();
            c3.Attack();
            Console.WriteLine();

            // ==========================================
            // 5-TASK — Smart Devices
            // ==========================================
            Console.WriteLine("--- TASK 5: Smart Devices ---");
            Device d1 = new Phone();
            Device d2 = new Laptop();
            Device d3 = new TV();

            d1.TurnOn();
            d2.TurnOn();
            d3.TurnOn();

            Console.ReadLine(); 
        }
    }
}