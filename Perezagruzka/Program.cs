using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;
using Day7;

namespace Perezagruzka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tank t34 = new Tank("T34");
            //t34.TankInfo();

            Battle bat = new Battle();
            bat.Fight("T34", "Pantera", 5);

        }
    }
}
