using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp.Garages
{
    internal static class EnumarebleExtension
    {

        public static IEnumerable<Vehicle>? getbackFilteredList(Vehicle[] vehiclesInGarage, Vehicle vh)
        {

            IEnumerable<Vehicle> list = vehiclesInGarage;
            list = list
                .Where(x => x != null);

            string? fuel = vh.Fuel;
            int wheels = vh.WheelsNumer;
            int seat = vh.NumberOfSeat;
            int lenght = vh.Lenght;
            string? color = vh.Color;

            if (fuel != null)
            {
                list = list
                    .Where(x => x.Fuel == fuel);
            }

            if (wheels != 0)
            {
                list = list
                    .Where(x => x.WheelsNumer == wheels);
            }

            if (seat != 0)
            {
                list = list
                    .Where(x => x.NumberOfSeat == seat);
            }

            if (lenght != 0)
            {
                list = list
                    .Where(x => x.Lenght >= lenght);
            }

            if (color != null)
            {
                list = list
                    .Where(x => x.Color == color);
            }

            Console.Clear();
            foreach (var item in list)
                yield return item;


            
        }

    }
}
