using Deep_Build_Galactic.Properties;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;

namespace Deep_Build_Galactic
{
    public partial class MainForm : Form
    {
        private Control[] perkPanels = new Control[5];

        private Loadout currentLoadout;
        private CharContainer CC;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CC = new CharContainer(butD);
            perkPanels[0] = primaryPanel;
            perkPanels[1] = secondaryPanel;
            perkPanels[2] = eq1panel;
            perkPanels[3] = eq2panel;
            perkPanels[4] = eq3panel;
            Perk.AddIcon("Acid", Resources.Acid);
            Perk.AddIcon("Angle", Resources.Angle);
            Perk.AddIcon("Area", Resources.Area);
            Perk.AddIcon("Arrows", Resources.Arrows);
            Perk.AddIcon("Bag", Resources.Bag);
            Perk.AddIcon("BigRounds", Resources.BigRounds);
            Perk.AddIcon("Boot", Resources.Boot);
            Perk.AddIcon("Bulb", Resources.Bulb);
            Perk.AddIcon("Cold", Resources.Cold);
            Perk.AddIcon("Dice", Resources.Dice);
            Perk.AddIcon("DoubleEnergy", Resources.DoubleEnergy);
            Perk.AddIcon("DoubleTurret", Resources.DoubleTurret);
            Perk.AddIcon("EnergyUp", Resources.EnergyUp);
            Perk.AddIcon("Expansion", Resources.Expansion);
            Perk.AddIcon("Explosion", Resources.Explosion);
            Perk.AddIcon("Flame", Resources.Flame);
            Perk.AddIcon("Fuel", Resources.Fuel);
            Perk.AddIcon("Jar", Resources.Jar);
            Perk.AddIcon("LoveLocator", Resources.LoveLocator);
            Perk.AddIcon("MagPlus", Resources.MagPlus);
            Perk.AddIcon("MagSwap", Resources.MagSwap);
            Perk.AddIcon("MagWhat", Resources.MagWhat);
            Perk.AddIcon("MultiTarget", Resources.MultiTarget);
            Perk.AddIcon("Nuke", Resources.Nuke);
            Perk.AddIcon("NukeReturn", Resources.NukeReturn);
            Perk.AddIcon("PaintBall", Resources.PaintBall);
            Perk.AddIcon("Pickaxe", Resources.Pickaxe);
            Perk.AddIcon("PiercingRound", Resources.PiercingRound);
            Perk.AddIcon("Pirate", Resources.Pirate);
            Perk.AddIcon("Return", Resources.Return);
            Perk.AddIcon("Rockets", Resources.Rockets);
            Perk.AddIcon("Rounds", Resources.Rounds);
            Perk.AddIcon("Sands", Resources.Sands);
            Perk.AddIcon("ShieldCrack", Resources.ShieldCrack);
            Perk.AddIcon("ShieldDrop", Resources.ShieldDrop);
            Perk.AddIcon("ShieldExplosion", Resources.ShieldExplosion);
            Perk.AddIcon("ShieldFist", Resources.ShieldFist);
            Perk.AddIcon("ShieldHeart", Resources.ShieldHeart);
            Perk.AddIcon("ShieldHeat", Resources.ShieldHeat);
            Perk.AddIcon("Skull", Resources.Skull);
            Perk.AddIcon("Speaker", Resources.Speaker);
            Perk.AddIcon("Star", Resources.Star);
            Perk.AddIcon("Stunned", Resources.Stunned);
            Perk.AddIcon("Target", Resources.Target);
            Perk.AddIcon("TargetSkull", Resources.TargetSkull);
            Perk.AddIcon("TempDown", Resources.TempDown);
            Perk.AddIcon("TurretUp", Resources.TurretUp);
            Perk.AddIcon("WatchSwap", Resources.WatchSwap);
            SpawnPerks();
            LoadStuff();
        }

        private void SpawnPerks()
        {
            for (int p = 0; p < 5; p++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Customizable.perkBoxes[p, i, j] = new PictureBox();
                        Customizable.perkBoxes[p, i, j].Dock = DockStyle.Fill;
                        perkPanels[p].Controls.Add(Customizable.perkBoxes[p, i, j]);
                        Customizable.perkBoxes[p, i, j].BackgroundImageLayout = ImageLayout.Center;
                    }
                }
            }
        }

        private void LoadStuff()
        {
            var chars = Directory.GetDirectories(Directory.GetCurrentDirectory());
            Miner driller = new Miner(Path.GetDirectoryName(chars[0]), "", null);
            driller.LoadGear(chars[0]);
            driller.LoadPrimary(0);
            driller.LoadSecondary(0);
            driller.LoadEqipment();
        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            if (sender is Control button)
            {
                CC.Enter(button.Parent);
            }
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            if (sender is Control button)
            {
                CC.Leave(button.Parent);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChooseYourDestiny(object sender, EventArgs e)
        {
            if(sender is Control butt)
            {
                CC.SetChar(butt.Parent);
                //currentLoadout.SetChar(radioChar);
            }
        }
    }
}