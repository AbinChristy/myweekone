using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IShape, IFaces
    {
        private int baseLength;
        private int height;

        public Triangle(int b, int h)
        {
            baseLength = b;
            height = h;
        }

        public override int GetArea()
        {
            return (baseLength * height) / 2;
        }

        public int GetFaces()
        {
            return 3;
        }
    }
}
