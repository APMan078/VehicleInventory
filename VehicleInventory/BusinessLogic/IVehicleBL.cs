using System;
using System.Collections.Generic;
using System.Text;
using VehicleInventory.Models;

namespace VehicleInventory.BusinessLogic
{
    public interface IVehicleBL
    {
        MessageReturn AddVehicle(Vehicle model);
        MessageReturn EditVehicle(Vehicle model);
        MessageReturn DeleteVehicle(int id);
        List<Vehicle> GetAllVehicle();
        Vehicle GetVehicleById(int id);
    }
}
