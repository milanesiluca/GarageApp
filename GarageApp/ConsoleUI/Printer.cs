using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.ConsoleUI
{
    public static class Printer<T>
    {
        //public static void PrintSubMenu() {

        //    Console.WriteLine($"1- Register the entrance of a {typeof(T).Name}");
        //    Console.WriteLine($"2- Register the exit of a {typeof(T).Name}");
        //    Console.WriteLine($"3- Show the List of the {typeof(T).Name} parked in the garage");
        //    Console.WriteLine($"0- Exit");
        //    Console.Write("\nInsert your option: ");

        //}

        public static void PrintCategoryMenu() {
            Console.WriteLine($"1- Car");
            Console.WriteLine($"2- Motorbike");
            Console.WriteLine($"3- Buss");
            Console.WriteLine($"0- Back");
            Console.Write("\nInsert your option: ");
        }

        public static void PrintMainMenu() {

            Console.WriteLine($"1- Register the entrance of a veichle");
            Console.WriteLine($"2- Register the exit of a veichle");
            Console.WriteLine($"3- Show the List of the vehicles parked in the garage");
            Console.WriteLine($"0- Exit");
            Console.Write("\nInsert your option: ");
        }

    }
}
