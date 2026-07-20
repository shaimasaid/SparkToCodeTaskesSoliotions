namespace OnlineStoreCheckout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coupon? (yes/no): ");
            string answer = Console.ReadLine();

            bool coupon = answer == "yes";

            double price = 0;

            switch (code)
            {
                case 1:
                    price = 8.5;
                    break;
                case 2:
                    price = 12;
                    break;
                case 3:
                    price = 5;
                    break;
                default:
                    Console.WriteLine("Invalid product code");
                    return;
            }

            double subtotal = price * quantity;
            double discount = 0;

            if (coupon && subtotal > 20)
                discount = subtotal * 0.10;

            double afterDiscount = subtotal - discount;
            double tax = afterDiscount * 0.05;
            double total = afterDiscount + tax;

            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Total: " + total);
        }
    }
}