namespace Depi_Session07
{
    // Q2
    // Cube inherits from Shape.
    // Area() is hidden using new.

    public class Cube : Shape
    {
        public double Depth { get; set; }

        public Cube(double width, double height, double depth)
            : base(width, height)
        {
            Depth = depth;
        }

        public new double Area()
        {
            return base.Area() * Depth;
        }

        public void Print()
        {
            System.Console.WriteLine(
                $"Width = {Width}, Height = {Height}, Depth = {Depth}"
            );
        }
    }
}
