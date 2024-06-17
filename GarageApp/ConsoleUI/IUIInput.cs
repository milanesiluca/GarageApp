using GarageApp.Vehicles;

namespace GarageApp.ConsoleUI
{
    public interface IUIInput
    {
        bool setVehicleDetails(ref Vehicle newVh, bool filter);
    }
}