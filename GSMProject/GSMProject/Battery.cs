using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProject
{
    public enum BatteryType { LiIon = 0, NiMH = 1, NiCd = 2, LiPol = 3 }
    class Battery
    {
        public string model;
        public uint idleHours;
        public uint talkHours;
        public string battType;
    }
}
