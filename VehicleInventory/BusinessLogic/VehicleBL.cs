using System;
using System.Collections.Generic;
using System.Text;
using VehicleInventory.Models;
using VehicleInventory.Repository;

namespace VehicleInventory.BusinessLogic
{
    public class VehicleBL : IVehicleBL
    {
        public List<Vehicle> vehicle { get; set; } = new List<Vehicle>();
        public MessageReturn AddVehicle(Vehicle model)
        {
            int id = 0;
            var message = new MessageReturn();
            var ifExistingVinNo = vehicle.Find(x => x.VIN == model.VIN);
            if(ifExistingVinNo != null)
            {
                message.IsSuccess = false;
                message.ValidationMessage = "Vin No Exist.";
                return message;
            }
            else
            {
                foreach(var i in vehicle)
                {
                    id = i.Id;
                }
                model.Id = id++;
                vehicle.Add(model);
                message.IsSuccess = true;
                return message;
            }
            
        }
        public MessageReturn EditVehicle(Vehicle model)
        {
            var message = new MessageReturn();
            var ifExistingVinNo = vehicle.Find(x => x.Id != model.Id && x.VIN == model.VIN);
            if (ifExistingVinNo != null)
            {
                message.IsSuccess = false;
                message.ValidationMessage = "Vin No Exist.";
                return message;
            }

            if (model.Id > 0)
            {
                var item = vehicle.Find(x => x.Id == model.Id);
                if (item != null)
                {
                    item.Make = model.Make;
                    item.Model = model.Model;
                    item.VIN = model.VIN;
                    item.Year = model.Year;
                }
                message.IsSuccess = true; 
                return message;
            }
            else
            {
                message.IsSuccess = false;
                message.ValidationMessage = "Error in updating vehicle";
                return message;

            } 
        }

        public MessageReturn DeleteVehicle(int id)
        {
            var message = new MessageReturn();
            if (id > 0)
            {
                var item = vehicle.Find(x => x.Id == id);
                vehicle.Remove(item);

                message.IsSuccess = true;
                message.ValidationMessage = item.VIN +" is deleted.";
                
            }
            return message;
        }

       

        public List<Vehicle> GetAllVehicle()
        {
            if (vehicle.Count < 1)
            {
                VehicleTemporaryData item = new VehicleTemporaryData();
                vehicle.AddRange(item.GoodsList());
            }
            return vehicle;
        }

        public Vehicle GetVehicleById(int id)
        {
            if (id > 0)
            {
                var item = vehicle.Find(x => x.Id == id);
                return item;
            }
            return null;
        }
    }
}
