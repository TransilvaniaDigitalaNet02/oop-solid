namespace Solid.LSP.After
{
    // shapes have area
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public int Side { get; set; }

        public override double GetArea()
        {
            return Side * Side;
        }
    }

    public static class ShapeCalculator
    {
        public static void WorkWithShapes()
        {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 20;
            Console.WriteLine("Rectangle area: " + ((Shape)r).GetArea());

            Square s = new Square();
            s.Side = 20;
            Console.WriteLine("Rectangle area: " + ((Shape)s).GetArea());
        }
    }
}
