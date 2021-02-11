using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInventory.Models
{
    public class MessageReturn
    {
        public bool IsSuccess { get; set; }
        public string ValidationMessage { get; set; }
    }
}
