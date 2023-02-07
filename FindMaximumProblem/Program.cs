namespace FindMaximumProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find Maximum Problems Using Generics");
            Console.WriteLine("Please select given options");
            Console.WriteLine("1.FindStringMaximumValuesUsingGenericConcepts\n2.FindIntegerMaximumValuesUsingGenericConcepts\n3.FindFloatMaximumValuesUsingGenericConcepts\n4.Exit\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Please enter three string to find maximum values:");
                    string firstValue = Console.ReadLine();
                    string secondValue = Console.ReadLine();
                    string thirdValue = Console.ReadLine();
                    Console.WriteLine("String maximum number:\n-----------------------------");
                    GenericMaximum<string> genericString = new GenericMaximum<string>(firstValue, secondValue, thirdValue);
                    genericString.TestMaxMethod();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Please enter three integer values to find maximum values:");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    int thirdNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Integer maximum number:\n------------------------------");
                    GenericMaximum<int> genericInteger = new GenericMaximum<int>(firstNumber, secondNumber, thirdNumber);
                    genericInteger.TestMaxMethod();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Please enter three float values to find maximum values:");
                    double firstNum = Convert.ToDouble(Console.ReadLine());
                    double secondNum = Convert.ToDouble(Console.ReadLine());
                    double thirdNum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("float maximum number:\n---------------------------------");
                    GenericMaximum<double> genericFloat = new GenericMaximum<double>(firstNum, secondNum, thirdNum);
                    genericFloat.TestMaxMethod();
                    break;
                case 4:
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