namespace VotingEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have a valid ID? (yes/no): ");
            string answer = Console.ReadLine();

            bool hasID = answer.ToLower() == "yes";

            if (age >= 18 && hasID)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }
    }
}