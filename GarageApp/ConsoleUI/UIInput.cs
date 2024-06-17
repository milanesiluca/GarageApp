using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.ConsoleUI
{
    public class UIInput : IUIInput
    {
        public bool setVehicleDetails(ref Vehicle newVh)
        {

            bool valid = false;
            do
            {
                Console.Write("Insert Reg. Number: ");
                string? regNum = Console.ReadLine();
                if (!string.IsNullOrEmpty(regNum))
                {
                    newVh.RegNum = regNum.ToLower().Trim();
                    valid = true;
                }

            } while (!valid);

            valid = false;
            do
            {
                Console.Write("Insert fuel: ");
                string? fuel = Console.ReadLine();
                if (!string.IsNullOrEmpty(fuel))
                {
                    newVh.Fuel = fuel.ToLower().Trim();
                    valid = true;
                }

            } while (!valid);

            valid = false;
            do
            {
                Console.Write("Insert number of Wheels: ");
                string? insertedSeat = Console.ReadLine();
                valid = int.TryParse(insertedSeat, out int wheelsN);
                if (valid)
                    newVh.WheelsNumer = wheelsN;

            } while (!valid);

            valid = false;
            do
            {
                Console.Write("Insert number of seat: ");
                string? insertedSeat = Console.ReadLine();
                valid = int.TryParse(insertedSeat, out int seatN);
                if (valid)
                    newVh.NumberOfSeat = seatN;

            } while (!valid);

            valid = false;
            do
            {
                Console.Write("Insert length (cm): ");
                string? insertedLenght = Console.ReadLine();
                valid = int.TryParse(insertedLenght, out int lenght);
                if (valid)
                    newVh.Lenght = lenght;
            } while (!valid);

            valid = false;
            if (newVh is not Buss)
            {
                do
                {
                    Console.Write("Insert vehicle color: ");
                    string? color = Console.ReadLine();
                    if (!string.IsNullOrEmpty(color))
                    {
                        if (newVh is Car cVh)
                            cVh.Color = color;
                        else if (newVh is Motorbike mVh)
                            mVh.Color = color;
                        valid = true;
                    }
                } while (!valid);
            }
            else if (newVh is Buss bVh)
            {
                do
                {
                    Console.Write("Insert the height of the vehicle (cm): ");
                    string? insertedHeight = Console.ReadLine();
                    valid = int.TryParse(insertedHeight, out int height);
                    if (valid)
                        bVh.Height = height;
                } while (!valid);
            }


            return valid;
        }
    }
}
