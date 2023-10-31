namespace Solid.OCP.Before
{
    public enum ShapeType
    {
        Triangle,
        Rectangle,
        // Square
    }

    public abstract class Shape
    {
        public abstract ShapeType Type { get; }
    }

    public class TriangleShape : Shape
    {
        public override ShapeType Type
        {
            get { return ShapeType.Triangle; }
        }

        public double GetArea()
        {
            return 100D;
        }
    }

    public class RectangleShape : Shape
    {
        public override ShapeType Type
        {
            get { return ShapeType.Rectangle; }
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public static class AreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            // what happens when we need to introduce a new shape?
            switch(shape.Type)
            {
                case ShapeType.Triangle:
                    return ((TriangleShape)shape).GetArea();

                case ShapeType.Rectangle:
                    return ((RectangleShape)shape).GetArea();
            }

            return 0D;
        }
    }

    /*--------------------------------------------------------------------*/

    public enum CustomerType
    {
        RegularCustomer,
        VipCustomer
    }

    public class DiscountCalculator
    {
        public decimal CalculateDiscountForOrder(decimal orderTotal, CustomerType customerType)
        {
            // what happens when a new customer type appears?
            switch (customerType)
            {
                case CustomerType.RegularCustomer:
                    // regular customers get a 10% discount
                    return orderTotal * 0.1M;

                case CustomerType.VipCustomer:
                    // VIP customers get a 20% discount
                    return orderTotal * 0.2M;

                default:
                    return 0M;
            }
        }
    }
}
