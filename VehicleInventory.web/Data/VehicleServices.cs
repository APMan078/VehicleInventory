using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleInventory.BusinessLogic;

namespace VehicleInventory.web.Data
{
    public class VehicleServices
    {
        private readonly IVehicleBL _ivehicleBL;
        public VehicleServices(IVehicleBL ivehicleBL)
        {
            _ivehicleBL = ivehicleBL;
        }
        public async Task<List<VehicleInventory.Models.Vehicle>> GetVehicles()
        {
            var item = new List<VehicleInventory.Models.Vehicle>();
            item.AddRange(_ivehicleBL.GetAllVehicle());
            return item;
        }
        public async void DeleteVehicle(int Id)
        {
            _ivehicleBL.DeleteVehicle(Id);
        }

        public VehicleInventory.Models.Vehicle GetVehicleById(int Id)
        {
            var item = new VehicleInventory.Models.Vehicle();
            item = _ivehicleBL.GetVehicleById(Id);
            return item;
        }
        public void SaveUpdateVehicle(VehicleInventory.Models.Vehicle model)
        {
            if(model.Id > 0)
            {
                _ivehicleBL.EditVehicle(model);
            }
            else
            {
                _ivehicleBL.AddVehicle(model);
            }
        }

    }
}
