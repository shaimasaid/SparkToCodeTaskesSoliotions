namespace RestaurantBillwithMembershipDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total bill: ");
            double bill = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you a member? (yes/no): ");
            string answer = Console.ReadLine();

            bool member = answer == "yes";

            double discount = 0;

            if (bill > 20 && member)
            {
                discount = bill * 0.15;
            }

            double finalBill = bill - discount;

            Console.WriteLine("Original Bill: " + bill);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Bill: " + finalBill);
        }
    }
}