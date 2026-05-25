using System;

namespace PolymorphismHomework
{
    public class Payment
    {
        public virtual void Pay()
        {
            Console.WriteLine("Processing payment...");
        }
    }
}