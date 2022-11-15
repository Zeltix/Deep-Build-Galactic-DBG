using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class Perk : Thing
    {
        private static Dictionary<string, Image> icons = new Dictionary<string, Image>();
        private Perk(string name, string desc, Image icon) : base(name, desc, icon)
        {
        }
        static public Perk FromFile(string path)
        {
            string[] perkStats = File.ReadAllLines(path);
            return new Perk(perkStats[0], perkStats[1], icons[perkStats[2]]);
        }
        public static void AddIcon(string name, Image icon)
        {
            icons.Add(name, icon);
        }
    }
}
