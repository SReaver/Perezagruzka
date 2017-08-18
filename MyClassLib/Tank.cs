using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank

    {
        private string name { get; set; }
        private int ammunition { get; set; }
        private int armor { get; set; }
        private int mobility { get; set; }
        public bool isWinner;
    
        public Tank(string name, int ammunition, int armor, int mobility)
        {
            this.name = name;
            this.ammunition = ammunition;
            this.armor = armor;
            this.mobility = mobility;
            isWinner = false;

        }
        public string GetTankName()
        {
            return name;
        }



        //public Tank()
        //{

        //}
        public static Tank operator ^(Tank a, Tank b)
        {
            int tankA = 0;
            int tankB = 0;

            if (a.ammunition > b.ammunition)
                tankA++;
            else
                tankB++;
            if (a.armor > b.armor)
                tankA++;
            else
                tankB++;
            if (a.mobility > b.mobility)
                tankA++;
            else
                tankB++;

            if (tankA > tankB)
                return a;
            else if (tankA < tankB)
                return b;
            else
                return null;

        }

        public void TankInfo()
        {
            Console.WriteLine($"Имя танка: {name}\nБоекомплект: {ammunition}\nБроня: {armor}\nМобильность {mobility}");
            Console.WriteLine("----------------");
        }

    }
}
