namespace ShippingCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter region (A/B/C): ");
            char region = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double baseCost = 0;
            double extra = 0;

            switch (region)
            {
                case 'A':
                    baseCost = 1;
                    break;

                case 'B':
                    baseCost = 3;
                    break;

                case 'C':
                    baseCost = 7;
                    break;

                default:
                    Console.WriteLine("Invalid region");
                    return;
            }

            if (weight > 10)
                extra = 5;
            else if (weight > 5)
                extra = 2;

            Console.WriteLine("Base Cost: " + baseCost);
            Console.WriteLine("Extra Charge: " + extra);
            Console.WriteLine("Total Cost: " + (baseCost + extra));
        }
    }
}