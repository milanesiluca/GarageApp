using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.ConsoleUI
{
    public class UIInput : IUIInput
    {
        public bool setVehicleDetails(ref Vehicle newVh, bool filter = false)
        {

            bool valid = filter;
            do
            {
                if (filter != true)
                {
                    Console.Write("Insert Reg. Number: ");
                    string? regNum = Console.ReadLine();
                    if (!string.IsNullOrEmpty(regNum))
                    {
                        newVh.RegNum = regNum.ToLower().Trim();
                        valid = true;
                        
                    }
                    else
                        Console.WriteLine("Please set a valid reg number");

                }
                else
                    valid = true;

            } while (!valid);

            valid = filter;
            do
            {
                Console.Write("Insert fuel: ");
                string? fuel = Console.ReadLine();
                if (!string.IsNullOrEmpty(fuel))
                {
                    newVh.Fuel = fuel.ToLower().Trim();
                    valid = true;
                }
                else
                    Console.WriteLine("Please set a valid fuel");

            } while (!valid && filter == false);

            valid = filter;
            do
            {
                Console.Write("Insert number of Wheels: ");
                string? insertedSeat = Console.ReadLine();
                valid = int.TryParse(insertedSeat, out int wheelsN);
                if (valid)
                    newVh.WheelsNumer = wheelsN;
                else
                    Console.WriteLine("Please set a valid number");

            } while (!valid && filter == false);

            valid = filter;
            do
            {
                Console.Write("Insert number of seat: ");
                string? insertedSeat = Console.ReadLine();
                valid = int.TryParse(insertedSeat, out int seatN);
                if (valid)
                    newVh.NumberOfSeat = seatN;
                else
                    Console.WriteLine("Please set a valid number");

            } while (!valid && filter == false);

            valid = filter;
            do
            {
                Console.Write("Insert length (cm): ");
                string? insertedLenght = Console.ReadLine();
                valid = int.TryParse(insertedLenght, out int lenght);
                if (valid)
                    newVh.Lenght = lenght;
                else
                    Console.WriteLine("Please set a valid lenght");
            } while (!valid && filter == false);

            valid = filter;
            do
            {
                Console.Write("Insert vehicle color: ");
                string? color = Console.ReadLine();
                if (!string.IsNullOrEmpty(color))
                {
                    newVh.Color = color;
                    valid = true;
                }
                else
                    Console.WriteLine("Please set a valid color");
            } while (!valid);

            valid = filter;
            if (newVh is not Motorbike && filter == false)
            {
                if (newVh is Car cVh)
                {
                    do
                    {
                        Console.Write("Insert Number of doors: ");
                        string? doors = Console.ReadLine();
                        valid = int.TryParse(doors, out int doorsNum);
                        if (valid)
                            cVh.Doors = doorsNum;
                        else
                            Console.WriteLine("Please set a valid number");

                    } while (!valid && filter == false);

                }
                else if (newVh is Buss bVh && filter == false)
                {
                    do
                    {
                        Console.Write("Insert the height of the vehicle (cm): ");
                        string? insertedHeight = Console.ReadLine();
                        valid = int.TryParse(insertedHeight, out int height);
                        if (valid)
                            bVh.Height = height;
                        else
                            Console.WriteLine("Please set a valid height");
                    } while (!valid && filter == false);
                }


            }
            else
                valid = true;

            return valid;
        }
    }
}
