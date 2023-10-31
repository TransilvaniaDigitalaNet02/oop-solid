namespace Solid.OCP.After
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class TriangleShape : Shape
    {
        public override double GetArea()
        {
            return 100D;
        }
    }

    public class RectangleShape : Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public static class AreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            // new shape gets added via inheritance
            // existing code doesn't need to change because of working against abstractions
            // polymorphism ensures correct behavior according to type
            return shape.GetArea();
        }
    }

    /*--------------------------------------------------------------------*/

    public abstract class DiscountProvider
    {
        public abstract decimal GetDiscount();
    }

    public class NoDiscountProvider : DiscountProvider
    {
        public override decimal GetDiscount()
        {
            return 0M;
        }
    }

    public class RegularCustomerDiscountProvider : DiscountProvider
    {
        public override decimal GetDiscount()
        {
            return 0.1M;
        }
    }

    public class VipCustomerDiscountProvider : DiscountProvider
    {
        public override decimal GetDiscount()
        {
            return 0.2M;
        }
    }

    public class DiscountCalculator
    {
        public decimal CalculateDiscountForOrder(decimal orderTotal, DiscountProvider discountProvider)
        {
            // new discount providers are added via inheritance
            // existing code doesn't need to change because of working against abstractions
            // polymorphism ensures correct behavior according to type

            return orderTotal * discountProvider.GetDiscount();
        }
    }
}
