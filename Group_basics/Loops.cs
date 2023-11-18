using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_basics
{
    public class Loops
    {
        public static void populateAndPrintArrayUsingFor()
        {
            int count = 10;
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = i;
            }
            printArray(numbers,"for loop");
        }

        public static void populateAndPrintArrayUsingWhile()
        {
            int count = 10;
            int[] numbers = new int[count];
            
            while (count > 0) 
            {
                numbers[count-1] = count-1;
                count--;
            }
            printArray(numbers,"While loop");
        }

        private static void printArray(int[] arrNumbers, string loopName)
        {
            Console.WriteLine($"Element of array are when populated using {loopName}:\n");
            foreach (int c in arrNumbers)
            {
                Console.WriteLine(c);
            }
        }
    }
}
