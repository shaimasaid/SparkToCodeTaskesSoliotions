namespace TriangleTypeClassifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side 1: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 3: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Equilateral");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Isosceles");
                else
                    Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Invalid Triangle");
            }
        }
    }
}