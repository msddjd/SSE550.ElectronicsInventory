using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSE550.ElectronicInventory.Interfaces;

namespace SSE550.ElectronicInventory.Classes
{
    class Cellphone : ComputingDevice, ICall
    {
        public string service_provider
        {   get; set; }
        public string call(long number)
        {
            return "Calling " + number + " using " + service_provider + ".....";
        }
    }
}
