using System;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        Game G1 = new Game();// Defining the object (G1) of the Game Class
        private object videoplayer;// Function for playing sound

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)// class for load button
        {

            G1.Load(); //Calling Load function from Game Class
            Btn_load.Enabled = false; // Disabling Load button
            Btn_Spin.Enabled = true;// Enabling spin function
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.load);
            player.Play();// for playing the sound for load buttonm
            Assembly mygame = Assembly.GetExecutingAssembly();
            Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources._3");// Adding image in load function
            pictureBox1.Image = SimpleGame.Properties.Resources._3;

        }

        private void Btn_Spin_Click(object sender, EventArgs e)// class for spin button
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.spin);
            player.Play();// For playing sound for spin button
            Assembly mygame = Assembly.GetExecutingAssembly();
            Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources._2");// This is used to add image on spin function
            pictureBox1.Image = SimpleGame.Properties.Resources._2;
            G1.Spin(); //Calling Spin function from Game Class
            MessageBox.Show(G1.spinbullet.ToString());
            Btn_load.Enabled = false;// Disable the spin button
            Btn_Spin.Enabled = false;// Disable the spin button
            Btn_Shoot.Enabled = true;// Enabling shoot button
            Btn_ShootAway.Enabled = true;// Enabling shoot away function

        }

        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            G1.Shoot(); //Calling Shoot function from Game Class
            if (G1.lose == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                player.Play();// This sound will play on the click of shoot button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources.shoot.atself.jpg");// This image will show on the click of shoot button
                pictureBox1.Image = SimpleGame.Properties.Resources.shoot_atself;
                MessageBox.Show("you loose the game");// This message will pop up after loosing the game
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;


            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                player.Play();// This sound will play on the click of shoot button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources.shoot.atself.jpg");// Image will show on shoot button
                pictureBox1.Image = SimpleGame.Properties.Resources.shoot_atself;
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = true;// Enabling shoot button
                Btn_ShootAway.Enabled = true;//Enabling shoot away button
            }

        }

        private void Btn_ShootAway_Click(object sender, EventArgs e)
        {
            G1.ShootAway(); //Calling Shoot Away function from Game Class

            if (G1.lose == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                player.Play();// This sound will play on the click of shoot away button
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources.Shoot_away.jpg");// Image will show on the click of shoot away button
                pictureBox1.Image = SimpleGame.Properties.Resources.Shoot_away;
                MessageBox.Show("you loose the game"); // This message will pop up after loosing the game
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;
                // Disabling all buttons after loosing the game


            }
            else if (G1.win == 1 && G1.shootawaybullet == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                player.Play();
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources.Shoot_away.jpg");
                pictureBox1.Image = SimpleGame.Properties.Resources.Shoot_away;
                MessageBox.Show("you won the game and Score is 100"); // This message will pop up after win the game
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;
                // Disabling all buttons after win the game

            }
            else if (G1.win == 1 && G1.shootawaybullet == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                player.Play();
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources.Shoot_away.jpg");
                pictureBox1.Image = SimpleGame.Properties.Resources.Shoot_away;
                MessageBox.Show("you won the game and Score is 50");
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = false;
                Btn_ShootAway.Enabled = false;
                // Disabling all buttons after winning the game

            }
            else //
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(SimpleGame.Properties.Resources.shoot);
                player.Play();
                Assembly mygame = Assembly.GetExecutingAssembly();
                Stream myst = mygame.GetManifestResourceStream("SimpleGame.Resources.Shoot_away.jpg");
                pictureBox1.Image = SimpleGame.Properties.Resources.Shoot_away;
                Btn_load.Enabled = false;
                Btn_Spin.Enabled = false;
                Btn_Shoot.Enabled = true;
                Btn_ShootAway.Enabled = true;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Spin.Enabled = false;
            Btn_Shoot.Enabled = false;
            Btn_ShootAway.Enabled = false;
        }

        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();// This button will reload the game and we can play again


            // Btn_load.Enabled = true;
            // Btn_Spin.Enabled = false;
            // Btn_Shoot.Enabled = false;
            // Btn_ShootAway.Enabled = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
