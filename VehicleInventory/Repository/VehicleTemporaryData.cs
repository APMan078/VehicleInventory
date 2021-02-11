using System;
using System.Collections.Generic;
using System.Text;
using VehicleInventory.Models;

namespace VehicleInventory.Repository
{
    public class VehicleTemporaryData
    {
        public List<Vehicle> GoodsList()
        {
            var item = new List<Vehicle>
            {
                new Vehicle{Id = 1, Make="Civic",Model="Honda",VIN="12333aa",Year=2012},
                new Vehicle{Id = 2, Make="Mirage",Model="Mitsubishi",VIN="1233312",Year=2019},
            };
            return item;
        }
    }
}
