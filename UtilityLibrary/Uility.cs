namespace UtilityLibrary
{
    public class Utility<T>
    {
        public static bool InsertVehicle(T vehicle, ref T[] placeList)
        {
            if (placeList.Contains(vehicle))
            {
                Console.WriteLine("The Vehicle is alredy parked in the garage");
                return false;
            }
            try
            {
                placeList.Append(vehicle);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool RemoveVehicle(T vehicle, ref T[] placeList)
        {
            if (!placeList.Contains(vehicle))
            {
                Console.WriteLine("The Vehicle is not in parked in the garage");
                return false;
            }

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
    }
}
