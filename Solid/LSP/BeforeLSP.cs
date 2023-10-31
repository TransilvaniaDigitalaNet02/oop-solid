namespace Solid.LSP.Before
{
    public class Rectangle
    {
        // before this were non-virtual
        // but had to be made virtual because the derived class needs to ensure consistency
        // this is a first design smell - adding child classes should not impact base classes!
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }

    public static class ShapeCalculator
    {
        public static void WorkWithShapes()
        {
            Rectangle r = new Rectangle();
            r.Width = 20;
            r.Height = 30;
            Console.WriteLine("Rectangle area: " + r.GetArea());

            // but because of inheritance we can also do
            Rectangle s = new Square();
            s.Width = 20;
            s.Height = 30;
            // what's the area now?
            Console.WriteLine("Rectangle area: " + s.GetArea());
        }
    }
}
