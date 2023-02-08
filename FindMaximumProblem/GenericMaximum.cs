using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblem
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        //parameteric constructor
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// This method is used to sort the values using Generic.
        /// </summary>
        /// <param name="value"></param>

        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public void PrinSortValue()
        {
            Console.WriteLine("\nBefore Sorted elements are: \n-------------------------");
            foreach (T item in value)
            {
                Console.WriteLine(item);
            }
            T[] sortResult = Sort(this.value);
            Console.WriteLine("\nAfter Sorted elements are: \n--------------------------");
            foreach (T item in sortResult) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
