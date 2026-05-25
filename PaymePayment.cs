using System;

namespace PolymorphismHomework
{
    public class PaymePayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Paid with Payme");
        }
    }
}