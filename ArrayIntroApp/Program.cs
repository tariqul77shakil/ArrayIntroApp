using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[5];

            Console.WriteLine("Enter the elements of Arary");
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = Convert.ToInt16(Console.ReadLine());
            }
            

            Array.Sort(numberArray);
            Console.WriteLine("\nAfter sorting one dimensional array is =");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            Array.Reverse(numberArray);
            Console.WriteLine("\nSorting in decending order.");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            Console.WriteLine("\nUsing foreach loop every elements are ");

            foreach (int x in numberArray)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
