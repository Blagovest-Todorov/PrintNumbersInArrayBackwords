using System;

namespace PrintNumbersReversly
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); // read n numbers from the Console and reate such long an array
            int[] numbers = new int[num];

            for (int i = numbers.Length-1 ; i >= 0 ; i--)
            {
                int currNumber = int.Parse(Console.ReadLine());
                numbers[i] = currNumber;

            }
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
            
        }
    }
}
