namespace OOP_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine($"Arean av circle 1 är: {circle1.GetArea()}");
        }
    }

    public class Circle
    {
        //Attribute
        private int radius = 1;

        //Constructor
        public Circle(int Radius)
        {
            radius = Radius;
        }

        //Method
        public double GetArea()
        {
            double Area = (radius * radius * Math.PI);
            return Area;
        }
        
    }
}
