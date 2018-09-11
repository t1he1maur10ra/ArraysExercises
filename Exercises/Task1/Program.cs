using System;

namespace Task1
{
    public class Task1Example
    {
        public static void Main()
        {
            Console.WriteLine("Task 1");

            string[] inputs = new string[10];

            //Using a for loop to itterate through the array and input data into each element.
            for (int i = 1; i <= inputs.Length; i++)
            {
                Console.Write($"Please enter itemr {i}: ");
                inputs[i-1] = Console.ReadLine();
            }

            //Displays the data in the array
            foreach (object x in inputs)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Task 1 finished, press enter to exit...");
            Console.ReadLine();
        }

    }
}
