namespace SimpleGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_Spin = new System.Windows.Forms.Button();
            this.Btn_Shoot = new System.Windows.Forms.Button();
            this.Btn_ShootAway = new System.Windows.Forms.Button();
            this.Btn_PlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_load
            // 
            this.Btn_load.Location = new System.Drawing.Point(127, 48);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(75, 23);
            this.Btn_load.TabIndex = 0;
            this.Btn_load.Text = "Load";
            this.Btn_load.UseVisualStyleBackColor = true;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Btn_Spin
            // 
            this.Btn_Spin.Location = new System.Drawing.Point(127, 104);
            this.Btn_Spin.Name = "Btn_Spin";
            this.Btn_Spin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Spin.TabIndex = 1;
            this.Btn_Spin.Text = "Spin";
            this.Btn_Spin.UseVisualStyleBackColor = true;
            this.Btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // Btn_Shoot
            // 
            this.Btn_Shoot.Location = new System.Drawing.Point(127, 168);
            this.Btn_Shoot.Name = "Btn_Shoot";
            this.Btn_Shoot.Size = new System.Drawing.Size(75, 23);
            this.Btn_Shoot.TabIndex = 2;
            this.Btn_Shoot.Text = "Shoot";
            this.Btn_Shoot.UseVisualStyleBackColor = true;
            this.Btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // Btn_ShootAway
            // 
            this.Btn_ShootAway.Location = new System.Drawing.Point(127, 245);
            this.Btn_ShootAway.Name = "Btn_ShootAway";
            this.Btn_ShootAway.Size = new System.Drawing.Size(75, 23);
            this.Btn_ShootAway.TabIndex = 3;
            this.Btn_ShootAway.Text = "Shoot Away";
            this.Btn_ShootAway.UseVisualStyleBackColor = true;
            this.Btn_ShootAway.Click += new System.EventHandler(this.Btn_ShootAway_Click);
            // 
            // Btn_PlayAgain
            // 
            this.Btn_PlayAgain.Location = new System.Drawing.Point(365, 343);
            this.Btn_PlayAgain.Name = "Btn_PlayAgain";
            this.Btn_PlayAgain.Size = new System.Drawing.Size(75, 23);
            this.Btn_PlayAgain.TabIndex = 4;
            this.Btn_PlayAgain.Text = "Play Again";
            this.Btn_PlayAgain.UseVisualStyleBackColor = true;
            this.Btn_PlayAgain.Click += new System.EventHandler(this.Btn_PlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_PlayAgain);
            this.Controls.Add(this.Btn_ShootAway);
            this.Controls.Add(this.Btn_Shoot);
            this.Controls.Add(this.Btn_Spin);
            this.Controls.Add(this.Btn_load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_Spin;
        private System.Windows.Forms.Button Btn_Shoot;
        private System.Windows.Forms.Button Btn_ShootAway;
        private System.Windows.Forms.Button Btn_PlayAgain;
    }
}

