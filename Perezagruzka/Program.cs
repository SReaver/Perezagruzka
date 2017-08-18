using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;

namespace Perezagruzka
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank t34 = new Tank("T34");
            t34.TankInfo();
        }
    }
}
