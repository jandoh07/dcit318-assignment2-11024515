namespace dcit318_assignment2_11024515.AbstractClass
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) { Radius = radius; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) { Width = width; Height = height; }
        public override double GetArea() => Width * Height;
    }

}
