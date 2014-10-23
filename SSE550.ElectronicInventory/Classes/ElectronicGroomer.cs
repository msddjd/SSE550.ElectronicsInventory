using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSE550.ElectronicInventory.Interfaces;

namespace SSE550.ElectronicInventory.Classes
{
    class ElectronicGroomer : Electronic, ICharge
    {
        public float battery_life
        { get; set; }
            
        public string charge(int hours)
        {
            return "Charging " + this.ToString() + " For " + hours + " hours";
        }
        
        public string powerOn()
        {
            return "Powering On " + this.ToString();
        }

        public string powerOff()
        {
            return "Powering Off " + this.ToString();
        }
    }
}
