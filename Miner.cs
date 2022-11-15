using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class Miner : Thing
    {
        Customizable[][] stuff = new Customizable[3][];
        public Miner(string name, string desc, Image icon) : base(name, desc, icon)
        {
            stuff[0] = new Customizable[3];
            stuff[1] = new Customizable[3];
            stuff[2] = new Customizable[3];
        }
        public void LoadGear(string path)
        {
            var gear = Directory.EnumerateDirectories(path);
            foreach (var gearEntry in gear)
            {
                string[] gearStats = Path.GetFileName(gearEntry).Split(' ');
                int slot = int.Parse(gearStats[0]);
                int id = int.Parse(gearStats[1]);
                if (slot != 4)
                {
                    var cus = new Customizable(gearStats[2], "", null);
                    stuff[slot - 1][id - 1] = cus;
                    cus.LoadPerks(gearEntry);
                }
            }
        }
        public void LoadPrimary(int num)
        {
            stuff[0][num].DrawPerks(0);
        }
        public void LoadSecondary(int num)
        {
            stuff[1][num].DrawPerks(1);
        }
        public void LoadEqipment()
        {
            for (int i = 0; i < 3; i++)
            {
                stuff[2][i].DrawPerks(i + 2);
            }
        }
    }
}
