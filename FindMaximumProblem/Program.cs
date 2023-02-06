namespace FindMaximumProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find Maximum Problems Using Generics");
            Console.WriteLine("Please select given options");
            Console.WriteLine("1.FindIntergerMaximumNumber\n2.Exit\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Please enter three values to find maximum number:");
                    int firstValue = Convert.ToInt32(Console.ReadLine());
                    int secondValue = Convert.ToInt32(Console.ReadLine());
                    int thirdValue = Convert.ToInt32(Console.ReadLine());
                    int output = MaximumNumberCheck.MaxIntegerNumberCheck(firstValue, secondValue, thirdValue);
                    Console.WriteLine("{0} is the maximum number", output);
                    break;
                case 2:
                    Console.Clear();
                    break;
                default :
                    Console.Clear();
                    Console.WriteLine("Please select only given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}