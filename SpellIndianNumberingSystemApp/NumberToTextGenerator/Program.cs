using System;

namespace NumberToTextGenerator
{
    // Application start.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to convert it into words");
                int numberEntered  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numberEntered + "\t"+ NumberToTextGenerator.NumberToWord(numberEntered));
            }
            catch(System.OverflowException)
            { 
                Console.WriteLine("Unable to convert the entered number to text. Please try with smaller number ranging from 0 to 999999998.");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Only numbers supported.");
            }
            catch
            {
                Console.WriteLine("Unable to process. Please try again.");
            }
        }
    }
}
