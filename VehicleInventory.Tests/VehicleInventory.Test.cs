
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleInventory.BusinessLogic;
using VehicleInventory.Models;

namespace VehicleInventory.Tests
{
    [TestClass]
    public class VehicleInventory
    {
        [TestMethod]
        public void AddVehicle()
        {
            IVehicleBL vehicleBL = new VehicleBL();
            var model = new Vehicle();
            model.Id = 2;
            model.Make = "Chery";
            model.Model = "Tiggo 2";
            model.VIN = "aaaaa";
            model.Year = 2021;

            var AddVehicle = vehicleBL.AddVehicle(model);
            Assert.IsTrue(AddVehicle.IsSuccess);
        }
        [TestMethod]
        public void GetAllVehicle()
        {
            IVehicleBL vehicleBL = new VehicleBL();
            var item = vehicleBL.GetAllVehicle();

            Assert.IsNotNull(item);
        }
        [TestMethod]
        public void GetVehicleById()
        {
            IVehicleBL vehicleBL = new VehicleBL();
            var item = vehicleBL.GetVehicleById(1);

            Assert.IsNotNull(item);
        }

    }
}
