namespace FindMaximumProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find Maximum Problems Using Generics");
            Console.WriteLine("Please select given options");
            Console.WriteLine("1.FindFloatMaximumNumber\n2.Exit\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Please enter three values to find maximum number:");
                    string firstValue = Console.ReadLine();
                    string secondValue = Console.ReadLine();
                    string thirdValue = Console.ReadLine();
                    string result = MaximumNumberCheck.MaxStringNumberCheck(firstValue, secondValue,thirdValue);
                    Console.WriteLine("{0} is the maximum number", result);
                    break;
                case 3:
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