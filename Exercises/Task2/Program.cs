using System;

namespace Task2
{
    public class Task2Example
    {
        public static void Main()
        {
            int[] arr = new int[100];

            Console.WriteLine("Task 2");

            arr = populate(arr);

            frequency(arr);

            Console.WriteLine("Task 2 finished, press enter to exit...");
            Console.ReadLine();
        }

        //Populate the array with 100 random numbers between 1 and 99
        public static int[] populate(int[] _arr)
        {
            Random rand = new Random();

            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = rand.Next(1, 99);
            }
            return _arr;
        }

        public static void frequency(int[] _arr)
        {
            //Used nested for loops to go through all of the elements and count the frequency they appear in the array
            for(int i = 0; i < _arr.Length; i++)
            {
                int counter = 0;

                for(int j = 0; j < _arr.Length; j++)
                {
                    if (_arr[i] == _arr[j])
                        counter += 1;   
                }
                //Outouts the frequency for each element in the array
                Console.WriteLine($"{_arr[i]} frequency: {counter}");
            }
        }
    }
}
