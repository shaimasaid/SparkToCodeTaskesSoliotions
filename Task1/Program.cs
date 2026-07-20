namespace LoanEligibilitySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter monthly income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Do you have an existing loan? (yes/no): ");
            string answer = Console.ReadLine();

            bool hasLoan = answer == "yes";

            if (age >= 21 && age <= 60 && income >= 400 && !hasLoan)
            {
                Console.WriteLine("Eligible for loan");
            }
            else
            {
                if (age < 21 || age > 60)
                    Console.WriteLine("Age out of range");
                else if (income < 400)
                    Console.WriteLine("Income too low");
                else if (hasLoan)
                    Console.WriteLine("Has an existing loan");
            }
        }
    }
}