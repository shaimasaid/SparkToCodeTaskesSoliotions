namespace UniversityAdmissionDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Program (S/A): ");
            char program = Convert.ToChar(Console.ReadLine());

            Console.Write("GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Exam Score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.Write("Extracurricular? (yes/no): ");
            string answer = Console.ReadLine();

            bool activity = answer == "yes";

            switch (program)
            {
                case 'S':
                    if (gpa >= 3.0 && score >= 75)
                        Console.WriteLine("Admitted");
                    else if (activity)
                        Console.WriteLine("Conditionally Admitted");
                    else
                        Console.WriteLine("Not Admitted");
                    break;

                case 'A':
                    if (gpa >= 2.5 && score >= 60)
                        Console.WriteLine("Admitted");
                    else if (activity)
                        Console.WriteLine("Conditionally Admitted");
                    else
                        Console.WriteLine("Not Admitted");
                    break;

                default:
                    Console.WriteLine("Invalid program type");
                    break;
            }
        }
    }
}