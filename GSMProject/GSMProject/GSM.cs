using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProject
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;

        internal GSM(string model, string manufact)
        {
            this.model = model;
            this.manufacturer = manufact;
            price = 0;
            owner = null;
            battery = new Battery();
            display = new Display();
        }

        internal GSM(string model, string owner, Display disp) : this("Mi Mix 2", "Xiaomi")
        {
            this.model = model;
            this.owner = owner;
            display.size = disp.size;
            display.numColors = disp.numColors;
            price = 0;
            battery = null;
        }

        internal GSM(string model, string manufact, string owner, Display disp, Battery batt)
        {
            this.model = model;
            this.manufacturer = manufact;
            this.owner = owner;
            display.size = disp.size;
            display.numColors = disp.numColors;
            battery.model = batt.model;
            battery.idleHours = batt.idleHours;
            battery.talkHours = batt.talkHours;
            price = 0;
        }

        public override string ToString()
        {
            Console.WriteLine("GSM informations: ");
            return ($@"
            Manufacturer: {this.manufacturer} 
                   Model: {this.model}
                   Price: {this.price}
                   Owner: {this.owner}
            BatteryModel: { this.battery.model}
        BatteryIdleHours: { this.battery.idleHours}
        BatteryTalkHours: { this.battery.talkHours}
             BatteryType: { this.battery.battType}
             DisplaySize: { this.display.size}
        DisplayNumColors: { this.display.numColors}
            ");
        }

        internal string Model{ get; set; }

        internal string Manufacturer { get; set; }

        internal double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value > 0)
                {
                    this.price = value;
                }
                else
                {
                    Console.WriteLine("Not a positive price");
                }
            }
        }

        internal string Owner { get; set; }
    }
}
