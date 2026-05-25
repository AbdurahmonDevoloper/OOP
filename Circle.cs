using System;

namespace PolymorphismHomework
{
    public class Circle : Shape
    {
        // Override — parentdan kelgan metodni qayta yozish
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }
}