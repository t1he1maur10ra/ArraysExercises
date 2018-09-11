using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Task3Example
    {
        public static void Main()
        {
           
            int[] arr = new int[100];

            arr = UniquePopulation(arr);

            Display(arr);

            ContainsCheck(arr);

            Console.ReadLine();
        }

        static int[] UniquePopulation(int[] _arr)
        {
            Random rand = new Random();

            for (int i = 0; i < _arr.Length; i++)
            {
                int num = rand.Next(1, 101);
                do
                {
                    num = rand.Next(1, 101);
                } while (_arr.Contains(num));

                _arr[i] = num;

            }
            return _arr;
        }

        static void Display(int[] _arr)
        {
            Array.Sort(_arr);

            foreach (int x in _arr)
            {
                Console.WriteLine(x);
            }
        }

        static void ContainsCheck (int[] _arr)
        {
            Console.Write("Please enter a nuber and ill check if its in the array: ");
            int value = int.Parse(Console.ReadLine());
            if (_arr.Contains(value))
            {
                int index = Array.IndexOf(_arr, value);
                Console.WriteLine($"The value {value} was found at index {index}");
            }
            else
                Console.WriteLine($"The value {value} was not found in the array");
        }
    }
}
