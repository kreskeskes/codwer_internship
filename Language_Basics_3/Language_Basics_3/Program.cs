using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {


        //check if this word has repeating chars
        Console.WriteLine("Enter the number of words that you'd like to have");
        int countOfWords = Convert.ToInt32(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < countOfWords; i++)
        {
            Console.WriteLine("Enter the new word.");
            string word = Console.ReadLine().ToUpper();
            words.Add(word);
        }
        string unitedString = null;
        foreach (string word in words)
        {
            unitedString += word;
        }
        foreach (string s in words)
        {
            for (int i = 0; i < s.Length; i++)
            {

                int occurrences = s.Count(temp => temp == s[i]);
                //Using LINQ features to get the count of elements that satisfy the lambda expression condition
                Console.WriteLine($"Occurrences of letter: {s[i]} in the word {s} is {occurrences} times");

            }
            Console.WriteLine();

        }
        foreach (char character in unitedString)
        {

            int occurrencesInTheWhole = unitedString.Count(temp => temp == character);
            Console.WriteLine($"Occurrences of letter: {character} in all of the names in the string of {unitedString} is {occurrencesInTheWhole} times");
        }

        Console.ReadKey();

    }
}