namespace CSharpLabAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new();
            Rectangle r1 = new Rectangle();

            Console.WriteLine();
            Console.WriteLine("CIRCLE CALCULATOR");
            Console.Write("Enter the radius of the circle: ");
            c1.radius = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Circle area: " + c1.calculateArea());
            Console.WriteLine("Circle perimeter: " + c1.calculatePerimeter());

            Console.WriteLine();
            Console.WriteLine("RECTANGLE CALCULATOR");
            Console.Write("Enter the length of the rectangle: ");
            r1.length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            r1.width = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Rectangle area: " + r1.calculateArea());
            Console.WriteLine("Rectangle perimeter: " + r1.calculatePerimeter());
        }
    }
}