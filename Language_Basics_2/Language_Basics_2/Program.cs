using System;

namespace Language_Basics_2
{
    internal class Program
    {
        static void Main()
        {
            int arraySize = 1;
            double[] numArray = new double[arraySize]; // initialize the array with size 1


            string reply = null; //initialize variable for holding the replies for do-while
            int indexElement = 0;//initialize the index of an element that we'll increment it once we create a new element
            do
            {
                if (indexElement >= numArray.Length - 1)// checks if the current index is not within the range
                {
                    //if it's not then the array has to be resized with the new size value
                    int tempSize = arraySize++;
                    Array.Resize(ref numArray, tempSize);
                }
                Console.WriteLine("Please enter the numerical value you would like to add to the array");
                double number = Convert.ToDouble(Console.ReadLine());
                numArray[indexElement] = number; //we assign the value to the index
                indexElement++; //index is incremented


                Console.WriteLine("Would you like to add another a number to your array? Y/N");


                reply = Console.ReadLine();

            } while ((reply.ToUpper() == "Y" || reply.ToUpper() == "YES") && indexElement < arraySize);
            // Adding elements sequence executes as long as user inputs y or yes

            Console.WriteLine("The list of integer elements in array: ");

            double[] doubleArray = new double[numArray.Length]; // we initialize an array for values with decimal point only
            int successCount = 0;
            // this is needed to use it as an index and in order to determine the count of elements to which the doubleArray
            //will ultimately be resized to

            for (int i = 0; i < numArray.Length; i++)
            {

                string temp = numArray[i].ToString();
                if (!temp.Contains("."))
                {
                    continue; //skips all the values that don't contain .
                }
                else
                {
                    doubleArray[successCount] = Convert.ToDouble(numArray[i]); // we add values to our new array, using successCount to help us identify its index
                    successCount++;
                }
            }

            Array.Resize(ref doubleArray, successCount); //we resize our doubles array according to count of elements
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);//print all double values
            }
            double minValue = 0; // initialize the min value
            for (int i = 0; i < doubleArray.Length; i++)
            {
                for (int j = 0; j < doubleArray.Length; j++)
                {
                    if (doubleArray[i] < doubleArray[j])
                    {
                        minValue = doubleArray[i];
                    }
                    else
                    {
                        minValue = doubleArray[j];
                    }
                }
            }
            //compare each an element of array i to every element of array j until we run out of array i characters

            Console.WriteLine($"The minimal value was: {minValue}");

            Console.ReadKey();
        }
    }
}
