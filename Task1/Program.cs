namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Fahrenheit = " + fahrenheit);

            if (celsius < 10)
            {
                Console.WriteLine("Weather: Cold");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("Weather: Mild");
            }
            else
            {
                Console.WriteLine("Weather: Hot");
            }
        }
    }
}