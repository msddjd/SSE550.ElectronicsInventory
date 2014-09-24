using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE550.ElectronicInventory
{
    class ComputingDevices : Electronics
    {
        private
            int hd_size, 
                ram;
            float battery_life;
            string cpu,
                disk_type;

        public int Hd_size
        {
            get { return hd_size; }
            set { hd_size = value; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public float Battery_life
        {
            get { return battery_life; }
            set { battery_life = value; }
        }

        public string Cpu
        {
            get { return cpu; }
            set { cpu = value; }
        }

        public string Disk_type
        {
            get { return disk_type; }
            set { disk_type = value; }
        }

    }
}
