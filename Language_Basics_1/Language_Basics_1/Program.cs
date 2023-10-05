using System;
using System.Text.RegularExpressions;

namespace Language_Basics_1
{
    internal class Program
    {
        static void Main()
        {
        inputNumber:
            Console.WriteLine("Please enter a number with at least 3 digits");
            string numStr = Console.ReadLine();
            string newNumStr = null;
            //regular expression to check restrict the input to numbers only
            Regex regex = new Regex("^[0-9]*$");
            if (regex.IsMatch(numStr) && numStr.Length >= 3)
            {
                //reversing the string and adding the received characters to newNumStr
                for (int i = numStr.Length - 1; i >= 0; i--)
                {
                    newNumStr += numStr[i];
                }
                int number = Convert.ToInt32(newNumStr);
                double squareRoot = Math.Sqrt(number);
                if (number / squareRoot == squareRoot)
                {
                    Console.WriteLine("The number is a perfect square");
                }
                else
                {
                    Console.WriteLine("The number is not a perfect square");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please input a number with at least 3 digits");
                goto inputNumber;
            }
            Console.ReadKey();

        }
    }
}
