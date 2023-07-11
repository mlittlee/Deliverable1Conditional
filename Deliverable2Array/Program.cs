using System;

namespace Deliverable2Array
{
    class Program
    {
        static int[] RandomArray(int arrayLen)
        {
            Random random = new Random();
            int[] myArray = new int[arrayLen];

            for (int i = 0; i < arrayLen; i++)
            {
                myArray[i] = random.Next(1, 50 + i);
            }

            return myArray;
        }

        static int totalSum(int[] array)
        {
            int totalSum = 0;

            foreach (int number in array)
            {
                totalSum += number;
            }

            return totalSum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15:");

                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {
                    int[] myArray = RandomArray(input);

                    Console.Write("The elements in the random array are: ");
                    foreach (int number in myArray)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("The sum is: " + totalSum(myArray));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 5 and 15.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }
        }
    }
}
