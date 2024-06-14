namespace UtilityLibrary
{
    public static class Utility<T>
    {
        public static bool InsertVehicle(T vehicle, ref T[] placeList)
        {
            
            try
            {
                int index = placeList.Count(vv => vv != null);
                if (index == 0) 
                    placeList[0] = vehicle;
                else
                    placeList[index] = vehicle;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RemoveVehicle(T vehicle, ref T[] placeList)
        {
            

            try
            {
                placeList = placeList.
                            Where(vh => !vh!.Equals(vehicle)).ToArray();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void ShowVehiclesListInGarage(ref T[] listVehicles)
        {
            int vehicleInPark = listVehicles.Count(vv => vv != null);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n * {typeof(T).Name} parked in garage: {vehicleInPark} * ");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < vehicleInPark; i++)
            {
                var vehicle = listVehicles[i];
                if (vehicle != null)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
        }

    }
}
