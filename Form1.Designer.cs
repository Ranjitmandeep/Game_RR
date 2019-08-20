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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_Spin = new System.Windows.Forms.Button();
            this.Btn_Shoot = new System.Windows.Forms.Button();
            this.Btn_ShootAway = new System.Windows.Forms.Button();
            this.Btn_PlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_load
            // 
            this.Btn_load.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_load.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_load.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_load.Location = new System.Drawing.Point(79, 165);
            this.Btn_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(172, 104);
            this.Btn_load.TabIndex = 0;
            this.Btn_load.Text = "Load";
            this.Btn_load.UseVisualStyleBackColor = false;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Btn_Spin
            // 
            this.Btn_Spin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Spin.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Spin.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Spin.Location = new System.Drawing.Point(79, 368);
            this.Btn_Spin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Spin.Name = "Btn_Spin";
            this.Btn_Spin.Size = new System.Drawing.Size(172, 97);
            this.Btn_Spin.TabIndex = 1;
            this.Btn_Spin.Text = "Spin";
            this.Btn_Spin.UseVisualStyleBackColor = false;
            this.Btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // Btn_Shoot
            // 
            this.Btn_Shoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Shoot.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Shoot.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Shoot.Location = new System.Drawing.Point(914, 165);
            this.Btn_Shoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Shoot.Name = "Btn_Shoot";
            this.Btn_Shoot.Size = new System.Drawing.Size(172, 104);
            this.Btn_Shoot.TabIndex = 2;
            this.Btn_Shoot.Text = "Shoot";
            this.Btn_Shoot.UseVisualStyleBackColor = false;
            this.Btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // Btn_ShootAway
            // 
            this.Btn_ShootAway.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ShootAway.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShootAway.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_ShootAway.Location = new System.Drawing.Point(914, 354);
            this.Btn_ShootAway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ShootAway.Name = "Btn_ShootAway";
            this.Btn_ShootAway.Size = new System.Drawing.Size(172, 112);
            this.Btn_ShootAway.TabIndex = 3;
            this.Btn_ShootAway.Text = "Shoot Away";
            this.Btn_ShootAway.UseVisualStyleBackColor = false;
            this.Btn_ShootAway.Click += new System.EventHandler(this.Btn_ShootAway_Click);
            // 
            // Btn_PlayAgain
            // 
            this.Btn_PlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_PlayAgain.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PlayAgain.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_PlayAgain.Location = new System.Drawing.Point(524, 527);
            this.Btn_PlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_PlayAgain.Name = "Btn_PlayAgain";
            this.Btn_PlayAgain.Size = new System.Drawing.Size(202, 107);
            this.Btn_PlayAgain.TabIndex = 4;
            this.Btn_PlayAgain.Text = "Play Again";
            this.Btn_PlayAgain.UseVisualStyleBackColor = false;
            this.Btn_PlayAgain.Click += new System.EventHandler(this.Btn_PlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 300);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(395, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 85);
            this.label1.TabIndex = 6;
            this.label1.Text = "Russian Roullete";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::SimpleGame.Properties.Resources.sky_blue;
            this.ClientSize = new System.Drawing.Size(1172, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_PlayAgain);
            this.Controls.Add(this.Btn_ShootAway);
            this.Controls.Add(this.Btn_Shoot);
            this.Controls.Add(this.Btn_Spin);
            this.Controls.Add(this.Btn_load);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_Spin;
        private System.Windows.Forms.Button Btn_Shoot;
        private System.Windows.Forms.Button Btn_ShootAway;
        private System.Windows.Forms.Button Btn_PlayAgain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

