using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE550.ElectronicInventory.Interfaces
{
    interface ICharge
    {
        float battery_life { get; set;}
        string charge(int hours);        
    }
}
