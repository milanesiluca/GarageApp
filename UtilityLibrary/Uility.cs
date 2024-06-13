namespace UtilityLibrary
{
    public class Utility<T>
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
    }
}
