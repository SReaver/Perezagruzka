using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;

namespace Day7
{
    public class Battle
    {
        Random rnd = new Random();
        List<Tank> CreateArmy(string name, int count)
        {
            List<Tank> list = new List<Tank>();
            for (int i = 0; i < count; i++)
            {
                Tank tank = new Tank(name, rnd.Next(1,100), rnd.Next(1, 100), rnd.Next(1, 100));
                list.Add(tank);
            }
            return list;
        }

        public string Fight(string name1, string name2, int count)
        {
            var army1 = CreateArmy(name1, count);
            var army2 = CreateArmy(name2, count);
            int team1, team2;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Сражается {army1[i].GetTankName()} и {army2[i].GetTankName()} ");
                Tank winner = army1[i] ^ army2[i];

                if (winner==army1[i])
                {
                    army1[i].isWinner = true;
                }
                else
                {
                    army2[i].isWinner = true;
                }
                winner.TankInfo();
            }
            team1 = army1.Where(c => c.isWinner == true).Count();
            team2 = army2.Where(c => c.isWinner == true).Count();
            return team1 > team2 ? name1 : (team1 < team2 ? name2 : "Ничья");


        }
    }
}
