using System;

namespace Deliverable_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a value between 1 and 100:");
            int input = GetUserInput(1, 100); //The (1, 100) acts as a range of acceptable user inputs

            string seriesName = GetSeriesName(); //This is worrying, as basic code does not account for null inputs in string. It is addressed in Line 48

            Console.WriteLine($"You have selected the {seriesName} series. The numbers between 0 and {input} are:");
            DisplaySeries(input, seriesName);
        }

        static int GetUserInput(int minValue, int maxValue)
        {
            int input;
            bool isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());

                    if (input >= minValue && input <= maxValue)
                    {
                        isValidInput = true;
                        return input;
                    }
                    else
                    {
                        Console.WriteLine($"This integer falls outside of the given parameters. Please enter an integer between {minValue} and {maxValue}:");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter an integer:"); //This covers anyone accidentally entering non-integers, like letters
                }
            }

            return 0; // This line is required with the GetUserInput (Line 18) as a default.
        }
        //After a few test runs of the program, I noticed that unless Odd or even were specifically chosen, the program would default to Odd series
        static string GetSeriesName()  
        {
            string seriesName;
            bool isValidInput = false; 

            while (!isValidInput)
            {
                Console.WriteLine("Specify the series of numbers you want displayed (even or odd):");
                seriesName = Console.ReadLine();

                if (seriesName.Equals("even", StringComparison.OrdinalIgnoreCase) || seriesName.Equals("odd", StringComparison.OrdinalIgnoreCase))
                {
                    isValidInput = true;
                    return seriesName.ToLower(); //.ToLower is so that the seriesName isn't displayed as "oDD" or other weird variations
                }
                else
                {
                    Console.WriteLine("Invalid series name. Please enter either 'even' or 'odd'.");
                }
            }

            return string.Empty; // This line is not expected to be reached
        }

        static void DisplaySeries(int maxValue, string seriesName)

        {
 // ? is a ternary operator. If seriesName = even, then startValue is 0, if it is not, then start value is 1.
            int startValue = seriesName == "even" ? 0 : 1; 
            int step = 2;

            while (startValue <= maxValue)
            {
                Console.Write(startValue + " ");
                startValue += step;
            }

            Console.WriteLine();
        }
    }
}
