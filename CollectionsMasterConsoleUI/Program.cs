using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
             var array = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            Populater(array);







            //TODO: Print the first number of the array

            Console.WriteLine(array[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(array.Length - 1);

            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            //Array.Reverse(array);


            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            var myArray2 = array;
             ReverseArray(myArray2);
            NumberPrinter(myArray2);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */

            Array.Sort(array);
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var myList = new List<int>();
            //TODO: Print the capacity of the list to the console

            Console.WriteLine(myList.Capacity);
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(myList);

            //TODO: Print the new capacity
            Console.WriteLine(myList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int randomNumber;

            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out randomNumber))
                {
                    break;
                }
                Console.WriteLine("Invalid entry;Try again");
            }

           

            NumberChecker(myList, randomNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            myList.Sort();

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            int[] transformers = myList.ToArray();
            
            //TODO: Clear the list

            myList.Clear();
            

            #endregion
        }

        

        private static void ThreeKiller(int[] numbers)
        {


            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i]%3 == 0)
                {
                    numbers[i] = 0;
                }

            }
            


        }

        private static void OddKiller(List<int> numberList)
        {

            for (int i = 0; i < numberList.Count; i++)
            {

                if (numberList[i]%2 !=0)
                {
                    numberList.Remove(numberList[i]);
                }

            }

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            for (int i = 0; i < numberList.Count; i++)
            {
                if (searchNumber == numberList[i])
                {
                    Console.WriteLine("Match");
                }
            }


        }

        private static void Populater(List<int> numberList)
        {

            Random random = new Random();

            for (int i = 0; i < 51; i++)
            {

                numberList.Add(random.Next(0,50));

            }



        }

        

        private static void ReverseArray(int[] array)
        {

            for (int i = array.Length - 1; i > 0; i--)
            {
                Console.WriteLine(array[i]);
            }

           // Array.Reverse(array);

           
        }

       private static void Populater(int[] numbers)
        {

           


            Random random = new Random();


         



            for (int i = 0; i < numbers.Length; i++)
            {

                numbers [i] = random.Next(0, 50);

            }

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
