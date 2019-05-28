using System;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        Game G1 = new Game();// Defining the object (G1) of the Game Class
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            G1.Load(); //Calling Load function from Game Class
            Btn_load.Enabled = false; // Disabling Load button
            Btn_Spin.Enabled = true;
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;

        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            G1.Spin(); //Calling Spin function from Game Class
            Btn_load.Enabled = false;
            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = true;
            Btn_ShootAway.Enabled = true;
        }

        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            G1.Shoot(); //Calling Shoot function from Game Class
            Btn_load.Enabled = false;
            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = true;
            Btn_ShootAway.Enabled = true;
        }

        private void Btn_ShootAway_Click(object sender, EventArgs e)
        {
            G1.ShootAway(); //Calling Shoot Away function from Game Class
            Btn_load.Enabled = false;
            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = true;
            Btn_ShootAway.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;
        }

        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Btn_load.Enabled = true;
            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;
        }
    }
}
