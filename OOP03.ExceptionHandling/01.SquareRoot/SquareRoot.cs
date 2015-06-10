namespace _01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("Number cannot be negative.");
                }

                Console.WriteLine("Square root is: {0}", Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Number is in invalid format.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number cannot be negative.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number is out of range for Int.");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
