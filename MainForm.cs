using Deep_Build_Galactic.Properties;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Deep_Build_Galactic
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Image> resources = new Dictionary<string, Image>();
        private PictureBox[,,] perkBoxes = new PictureBox[5,6,3];
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
            resources.Add("Acid", Resources.Acid);
            resources.Add("Angle", Resources.Angle);
            resources.Add("Area", Resources.Area);
            resources.Add("Arrows", Resources.Arrows);
            resources.Add("Bag", Resources.Bag);
            resources.Add("BigRounds", Resources.BigRounds);
            resources.Add("Boot", Resources.Boot);
            resources.Add("Bulb", Resources.Bulb);
            resources.Add("Cold", Resources.Cold);
            resources.Add("Dice", Resources.Dice);
            resources.Add("DoubleEnergy", Resources.DoubleEnergy);
            resources.Add("DoubleTurret", Resources.DoubleTurret);
            resources.Add("EnergyUp", Resources.EnergyUp);
            resources.Add("Expansion", Resources.Expansion);
            resources.Add("Explosion", Resources.Explosion);
            resources.Add("Flame", Resources.Flame);

            resources.Add("Fuel", Resources.Fuel);
            resources.Add("Jar", Resources.Jar);
            resources.Add("LoveLocator", Resources.LoveLocator);
            resources.Add("MagPlus", Resources.MagPlus);
            resources.Add("MagSwap", Resources.MagSwap);
            resources.Add("MagWhat", Resources.MagWhat);
            resources.Add("MultiTarget", Resources.MultiTarget);
            resources.Add("Nuke", Resources.Nuke);
            resources.Add("NukeReturn", Resources.NukeReturn);
            resources.Add("PaintBall", Resources.PaintBall);
            resources.Add("Pickaxe", Resources.Pickaxe);
            resources.Add("PiercingRound", Resources.PiercingRound);
            resources.Add("Pirate", Resources.Pirate);
            resources.Add("Return", Resources.Return);
            resources.Add("Rockets", Resources.Rockets);
            resources.Add("Rounds", Resources.Rounds);

            resources.Add("Sands", Resources.Sands);
            resources.Add("ShieldCrack", Resources.ShieldCrack);
            resources.Add("ShieldDrop", Resources.ShieldDrop);
            resources.Add("ShieldExplosion", Resources.ShieldExplosion);
            resources.Add("ShieldFist", Resources.ShieldFist);
            resources.Add("ShieldHeart", Resources.ShieldHeart);
            resources.Add("ShieldHeat", Resources.ShieldHeat);
            resources.Add("Skull", Resources.Skull);
            resources.Add("Speaker", Resources.Speaker);
            resources.Add("Star", Resources.Star);
            resources.Add("Stunned", Resources.Stunned);
            resources.Add("Target", Resources.Target);
            resources.Add("TargetSkull", Resources.TargetSkull);
            resources.Add("TempDown", Resources.TempDown);
            resources.Add("TurretUp", Resources.TurretUp);
            resources.Add("WatchSwap", Resources.WatchSwap);
            SpawnPerks();
        }

        private void SpawnPerks()
        {
            for (int p = 0; p < 5; p++)
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        perkBoxes[p, i, j] = new PictureBox();
                        perkBoxes[p, i, j].Dock = DockStyle.Fill;
                        perkPanels[p].Controls.Add(perkBoxes[p, i, j]);
                        perkBoxes[p, i, j].BackgroundImage = resources["Acid"];
                        perkBoxes[p, i, j].BackgroundImageLayout = ImageLayout.Center;
                    }
                }
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