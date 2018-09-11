using System;
using Task1;
using Task2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int task = Menu();
            switch(task)
            {
                case 0:
                    break;
                case 1:
                    Task1Example.Main();
                    break;
                case 2:
                    Task2Example.Main();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }

        }
        static int Menu ()
        {
            int selection = -1;
            bool check = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------");
                Console.Write("-----");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Please select from the options below ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----");
                Console.WriteLine("------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press 1 for task 1");
                Console.WriteLine("Press 2 for task 2");
                Console.WriteLine("Press 3 for task 3");
                Console.WriteLine("Press 4 for task 4");
                Console.WriteLine("Press 5 for task 5");
                Console.WriteLine("Press 6 for task 6");
                Console.WriteLine("Press 0 to exit");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------");
                Console.Write("---------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Selection [   ] ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------");
                Console.WriteLine("------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(28, 11);

                check = int.TryParse(Console.ReadLine(), out selection);

                Console.Clear();
            }
            while (check == false);

            return selection;
        }
    }
}
