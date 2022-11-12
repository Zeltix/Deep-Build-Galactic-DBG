using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class Build
    {
        private int Char
        {
            get;
        }
        private int[] Gear
        {
            get;
        }
        private int[][] PrimaryPerks
        {
            get;
        }
        private int[][] SecondaryPerks
        {
            get;
        }
        private int[][] EquipmentPerks
        {
            get;
        }

        public Build()
        {
            Char = 0;
            Gear = new int[3];
            PrimaryPerks = new int[4][];
            SecondaryPerks = new int[4][];
            EquipmentPerks = new int[4][];
        }
    }
}
