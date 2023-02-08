namespace FindMaximumProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Find Maximum Problems Using Generics");
            Console.WriteLine("Please select given options");
            Console.WriteLine("1.PrintStringSortValuesUsingGenericConcepts\n2.PrintIntegerSortValuesUsingGenericConcepts\n3.PrintFloatSortValuesUsingGenericConcepts\n4.Exit\n");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Clear();
                    string[] arrString = { "Mango", "Banana", "Orange", "Peach" };
                    GenericMaximum<string> genericString = new GenericMaximum<string>(arrString);
                    genericString.PrinSortValue();
                    break;
                case 2:
                    Console.Clear();
                    int[] arrInteger = { 105, 2159, 1125, 789, 998 };
                    GenericMaximum<int> genericInteger = new GenericMaximum<int>(arrInteger);
                    genericInteger.PrinSortValue();
                    break;
                case 3:
                    Console.Clear();
                    float[] arrFloat = { 105.25f, 25.9f, 350.29f, 78.925f, 998.8f };
                    GenericMaximum<float> genericFloat = new GenericMaximum<float>(arrFloat);
                    genericFloat.PrinSortValue();
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