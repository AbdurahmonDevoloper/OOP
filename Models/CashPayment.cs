using System;

namespace PolymorphismHomework
{
    public class CashPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Paid with Cash");
        }
    }
}