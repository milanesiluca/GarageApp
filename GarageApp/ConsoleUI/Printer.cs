using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.ConsoleUI
{
    public class Printer<T> : IPrinter<T>
    {

        public void PrintCategoryMenu()
        {
            Console.WriteLine($"1- Car");
            Console.WriteLine($"2- Motorbike");
            Console.WriteLine($"3- Buss");
            Console.WriteLine($"0- Back");
            Console.Write("\nInsert your option: ");
        }

        public void PrintMainMenu()
        {

            Console.WriteLine("1- Register the entrance of a veichle");
            Console.WriteLine("2- Register the exit of a veichle");
            Console.WriteLine("3- Show the List of the vehicles parked in the garage");
            Console.WriteLine("4- Filter parked vehicles by vehicle type");
            Console.WriteLine("5- Filter parked vehicles by technical features");
            Console.WriteLine("0- Exit");
            Console.Write("\nInsert your option: ");
        }

    }
}
