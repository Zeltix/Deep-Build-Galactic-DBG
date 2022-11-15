using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class Loadout
    {
        public int Char
        {
            get;
        }
        public int[] Gear
        {
            get;
        }
        public int[][] PrimaryPerks
        {
            get;
        }
        public int[][] SecondaryPerks
        {
            get;
        }
        public int[][] EquipmentPerks
        {
            get;
        }
        private int[][][] perks;

        public Loadout()
        {
            Char = 0;
            Gear = new int[3];
            PrimaryPerks = new int[3][];
            SecondaryPerks = new int[3][];
            EquipmentPerks = new int[3][];
            perks = new int[3][][];
            perks[0] = PrimaryPerks;
            perks[1] = SecondaryPerks;
            perks[2] = EquipmentPerks;
        }
        public void LoadPerks()
        {

        }

        internal void SetChar(int charNum)
        {
        }
    }
}
