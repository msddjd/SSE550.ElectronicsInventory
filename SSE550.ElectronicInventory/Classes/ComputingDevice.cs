using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSE550.ElectronicInventory.Interfaces;

namespace SSE550.ElectronicInventory.Classes
{
    abstract class ComputingDevice : Electronic, ICharge
    {
        public float battery_life
        { get; set; }

        public string charge(int hours)
        {
            return "Charging " + this.ToString() + " For " + hours + " hours";
        }        

        private
            int hd_size, 
                ram;            
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
