namespace UtilityLibrary
{
    public class Utility<T>
    {
        public static bool InsertVehicle(T vehicle, ref T[] placeList)
        {
            
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
