using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public abstract class Shape : IShape
    {
        private int area;

        public abstract int GetArea();

        public void SetArea(int Area)
        {
            area = Area;
        }

        public string? Colour { get; set; }
    }
}
