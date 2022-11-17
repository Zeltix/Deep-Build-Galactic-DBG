using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class CharContainer
    {
        private Control currChar;
        public int CurrCharNum
        {
            get;
            private set;
        }
        public CharContainer(Control firstChar)
        {
            currChar = firstChar;
            CurrCharNum = 1;
        }

        public void Enter(Control chr)
        {
            if (currChar != chr)
                chr.BackColor = Color.Orange;
            else
                currChar.BackColor = Color.Green;
        }
        public void Leave(Control chr)
        {
            if (currChar != chr)
                chr.BackColor = Color.Transparent; 
            else 
                currChar.BackColor = Color.Blue;
        }
        public void SetChar(Control chr)
        {

            if (currChar != chr)
                currChar.BackColor = Color.Transparent;
            else return;
            currChar = chr;
            currChar.BackColor = Color.Green;
            CurrCharNum = GetCharNum(currChar);
        }
        private int GetCharNum(Control c)
        {
            switch (c.Name[3])
            {
                case 'D': return 1;
                case 'E': return 2;
                case 'G': return 3;
                case 'S': return 4;
            }
            throw new Exception("ABSOLUTELY FUCKED character button");
        }
    }
}
