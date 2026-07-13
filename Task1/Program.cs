namespace RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}