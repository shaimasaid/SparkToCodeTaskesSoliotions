namespace MovieTicketPricing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12)
            {
                Console.WriteLine("Category: Child");
                Console.WriteLine("Price: 2.000 OMR");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Category: Adult");
                Console.WriteLine("Price: 5.000 OMR");
            }
            else
            {
                Console.WriteLine("Category: Senior");
                Console.WriteLine("Price: 3.000 OMR");
            }
        }
    }
}