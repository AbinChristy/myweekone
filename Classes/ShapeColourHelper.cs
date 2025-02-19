using Week1ObjectOriented.Interfaces;
using System;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static readonly string[] Colours = { "Yellow", "Red", "Blue", "Green", "Orange" };
        private static readonly Random random = new Random();
        public static Shape AssignRandomColour(Shape s)
        {
            s.Colour = Colours[random.Next(Colours.Length)];
            return s;
        }
    }
}
