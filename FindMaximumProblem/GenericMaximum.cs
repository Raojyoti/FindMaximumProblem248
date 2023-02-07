using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        //parameteric constructor
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        /// <summary>
        /// This method is used to find maximum value using Generic.
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <param name="thirdValue"></param>
        /// <returns></returns>
        public static T MaxValueCheck(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue ,SecondValue and thirdValue are same");
        }
        public void TestMaxMethod()
        {
            T result= MaxValueCheck(firstValue, secondValue, thirdValue);  
            Console.WriteLine("Max Value: "+result);
        }
    }
}
