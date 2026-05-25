using System;

namespace PolymorphismHomework
{
    public class ClickPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Paid with Click");
        }
    }
}