using GarageApp.Garages;
using GarageApp.Vehicles;
using System.Security.Cryptography.X509Certificates;

namespace GarageTest
{
    public class GarageUnitTest
    {
        VehiclesGarage garage;

        public GarageUnitTest()
        {
            garage = new(10);
        }

        [Fact]
        public void AddVehicleToGagate_Test_Correct()
        {
            //Arrange
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
            Vehicle? vh = new Vehicle();
            vh.RegNum = "AAbbCC";
            garage.AddVehicleToParking(vh);

            string regNum = "aabbCC";


            //Acr
            garage.RemoveVehicleFromGarage(regNum);



            //Assert
            Assert.Empty(garage);

        }

        [Fact]
        public void RemoveVehiclefromParking_Wrong()
        {

            //Arrange
            Vehicle? vh = new Vehicle();
            vh.RegNum = "AAbbCC";
            garage.AddVehicleToParking(vh);

            string regNum = "ssssss";


            //Acr
            garage.RemoveVehicleFromGarage(regNum);
            //Assert
            Assert.NotEmpty(garage);

        }

        [Fact]
        public void FilterVehicleListByType_Test() { 
            
            //Assert
            Car caar = new Car();
            caar.RegNum = "AA444BB";
            garage.AddVehicleToParking(caar);

            Buss buss = new Buss();
            buss.RegNum = "ff444ff";
            garage.AddVehicleToParking(buss);

            //Act
            IEnumerable<Vehicle>? listCar = garage.FilterVehicleListByType(typeof(Car));
            IEnumerable<Vehicle>? listMb = garage.FilterVehicleListByType(typeof(Motorbike));
            //Assert
            Assert.NotEmpty(listCar!);
            Assert.Empty(listMb!);

        }

        [Fact]
        public void FilterVehicleByFeature_Test() {

            //Arrange
            Vehicle vh1 = new Vehicle();
            vh1.WheelsNumer = 4;
            vh1.RegNum = "AA111BB";
            vh1.NumberOfSeat = 4;
            vh1.Fuel = "Diesel";
            vh1.Color = "Red";
            vh1.Lenght = 230;

            Vehicle vh2 = new Vehicle();
            vh2.WheelsNumer = 4;
            vh2.RegNum = "ff3322";
            vh2.NumberOfSeat = 4;
            vh2.Fuel = "Bensin";
            vh2.Color = "blue";
            vh2.Lenght = 230;

            Vehicle vh3 = new Vehicle();
            vh3.WheelsNumer = 4;
            vh3.RegNum = "AA111BB";
            vh3.NumberOfSeat = 4;
            vh3.Fuel = "Diesel";
            vh3.Color = "Red";
            vh3.Lenght = 230;

            garage.AddVehicleToParking(vh1);
            garage.AddVehicleToParking(vh2);
            garage.AddVehicleToParking(vh3);

            Vehicle tst1Vh = new Vehicle();
            tst1Vh.WheelsNumer = 0;
            tst1Vh.RegNum = null;
            tst1Vh.NumberOfSeat = 0;
            tst1Vh.Fuel = null;
            tst1Vh.Color = "Red";
            tst1Vh.Lenght = 0;

            Vehicle tst2Vh = new Vehicle();
            tst2Vh.Color = "white";

            

            //Act
            var result1 = EnumarebleLINQClass.getbackFilteredList(garage.VehiPlaces, tst1Vh);
            var result2 = EnumarebleLINQClass.getbackFilteredList(garage.VehiPlaces, tst2Vh);

            //Assert

            Assert.NotEmpty(result1!);
            Assert.Empty(result2!);

        }
    }
}