using GarageApp.Garages;
using GarageApp.Vehicles;
using System.Security.Cryptography.X509Certificates;

namespace GarageTest
{
    public class GarageUnitTest
    {
      

        [Fact]
        public void AddVehicleToGagate_Test_Correct()
        {
            //Arrange
            VehiclesGarage garage = new(10);
            Vehicle vh = new Vehicle();
            vh.WheelsNumer = 4;
            vh.RegNum = "AA111BB";
            vh.NumberOfSeat = 4;
            vh.Fuel = "Diesel";
            vh.Color = "Red";
            vh.Lenght = 230;

            var success = true;

            //Act
            var testSuccess = garage.AddVehicleToParking(vh);


            //Assert
            Assert.Equal(success, testSuccess);

        }

        [Fact]
        public void AddVehicleToGagate_Test_Wrong()
        {

            //Arrange
            VehiclesGarage garage = new(10);
            Vehicle? vh = null;
            var success = false;

            //Act
            var testSuccess = garage.AddVehicleToParking(vh!);


            //Assert
            Assert.Equal(success, testSuccess);
            

        }

        [Fact]
        public void RemoveVehiclefromParking_Correct() {

            //Arrange
            VehiclesGarage garage = new(10);
            Vehicle? vh = new Vehicle();
            vh.RegNum = "AAbbCC";
            garage.AddVehicleToParking(vh);

            string regNum = "aabbCC";


            //Acr
            garage.RemoveVehicleFromGarage(regNum);



            //Assert
            Assert.Empty(garage);

        }
    }
}