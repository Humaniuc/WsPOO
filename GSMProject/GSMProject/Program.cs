using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("Mi A2", "Xiaomi");
            Console.WriteLine(gsm.ToString()); 

            Console.ReadLine();
        }
    }
}
