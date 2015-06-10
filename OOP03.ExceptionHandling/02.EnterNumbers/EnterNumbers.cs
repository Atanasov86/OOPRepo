namespace _02.EnterNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class EnterNumbers
    {
        public static void Main()
        {

            int start = 1;
            int end = 100;
            int counter = 0;
            List<int> numbers = new List<int>();

            
            while (counter != 10)
            {
                int currentNumber = 1;
                try
                {
                    Console.Write("Please enter number: ");
                    currentNumber = ReadNumber(start, end);
                    numbers.Add(currentNumber);
                    start = currentNumber;
                    counter++;
                }
                catch (ArgumentNullException)
                {
                    Console.Error.WriteLine("Number cannot be null or empty.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("Number is out of this range[1,100]");
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Your number is invalid.");
                }
                catch (OverflowException)
                {
                    Console.Error.WriteLine("Your number is too big or small for Int");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException();
            }

            int number = int.Parse(input);
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}
