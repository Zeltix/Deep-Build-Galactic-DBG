using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Build_Galactic
{
    internal class Customizable : Thing
    {
        public static PictureBox[,,] perkBoxes = new PictureBox[5, 6, 3];
        private Perk[,] perks = new Perk[6, 3];
        public Customizable(string name, string desc, Image icon) : base(name, desc, icon)
        {
        }
        public void LoadPerks(string path)
        {
            var perk = Directory.EnumerateFiles(path);
            foreach (var perkEntry in perk)
            {
                string[] perkStats = Path.GetFileNameWithoutExtension(perkEntry).Split(' ');
                Debug.WriteLine(perkEntry);
                int slot = int.Parse(perkStats[0]);
                int id = int.Parse(perkStats[1]);
                perks[slot - 1, id - 1] = Perk.FromFile(perkEntry);
            }
        }
        public void DrawPerks(int panelID)
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (perks[i, j] != null)
                    {
                        perkBoxes[panelID, i, j].Image = perks[i, j].Icon;
                    }
                    else
                    {
                        perkBoxes[panelID, i, j].Image = null;
                    }
                    
                }
            }
        }
    }
}
