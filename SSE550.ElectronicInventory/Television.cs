using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE550.ElectronicInventory
{
    class Television : Electronics
    {
        private string technology;

        public string Technology
        {
            get
            {return technology;}
            set
            { technology = value; }            
        }
    }
}
