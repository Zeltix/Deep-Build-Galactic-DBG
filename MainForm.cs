using Deep_Build_Galactic.Properties;
using System.Diagnostics;

namespace Deep_Build_Galactic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void DrillerButton_MouseMove(object sender, EventArgs e)
        {

            if (sender == DrillerButton)
            {
                
            }
        }

        private void DrillerButton_MouseEnter(object sender, EventArgs e)
        {
            DrillerButton.BackColor = SystemColors.Control;
        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            if(sender is Control button) button.Parent.BackColor = Color.Orange;
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            if (sender is Control button) button.Parent.BackColor = Color.Transparent;
        }
    }
}