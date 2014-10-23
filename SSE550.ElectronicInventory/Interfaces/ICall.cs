using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE550.ElectronicInventory.Interfaces
{
    interface ICall
    {
        string service_provider { get; set; }
        string call(long number);
    }
}
