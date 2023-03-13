namespace Hotellitehtävä
{
    partial class kirjausFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kirjausFM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tunnistauduGB = new System.Windows.Forms.GroupBox();
            this.ssTB = new System.Windows.Forms.TextBox();
            this.ktunnusTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.ktunnusLB = new System.Windows.Forms.Label();
            this.kirjauduBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tunnistauduGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(795, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Kirjaudu sisään hotellijärjestelmään!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tunnistauduGB
            // 
            this.tunnistauduGB.Controls.Add(this.ssTB);
            this.tunnistauduGB.Controls.Add(this.ktunnusTB);
            this.tunnistauduGB.Controls.Add(this.salasanaLB);
            this.tunnistauduGB.Controls.Add(this.ktunnusLB);
            this.tunnistauduGB.Location = new System.Drawing.Point(108, 479);
            this.tunnistauduGB.Name = "tunnistauduGB";
            this.tunnistauduGB.Size = new System.Drawing.Size(576, 142);
            this.tunnistauduGB.TabIndex = 2;
            this.tunnistauduGB.TabStop = false;
            // 
            // ssTB
            // 
            this.ssTB.Location = new System.Drawing.Point(270, 87);
            this.ssTB.Name = "ssTB";
            this.ssTB.Size = new System.Drawing.Size(185, 26);
            this.ssTB.TabIndex = 3;
            this.ssTB.Text = "Password";
            this.ssTB.UseSystemPasswordChar = true;
            // 
            // ktunnusTB
            // 
            this.ktunnusTB.Location = new System.Drawing.Point(270, 40);
            this.ktunnusTB.Name = "ktunnusTB";
            this.ktunnusTB.Size = new System.Drawing.Size(185, 26);
            this.ktunnusTB.TabIndex = 2;
            this.ktunnusTB.Text = "Admin";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.Location = new System.Drawing.Point(29, 87);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(104, 26);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // ktunnusLB
            // 
            this.ktunnusLB.AutoSize = true;
            this.ktunnusLB.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktunnusLB.Location = new System.Drawing.Point(29, 40);
            this.ktunnusLB.Name = "ktunnusLB";
            this.ktunnusLB.Size = new System.Drawing.Size(179, 26);
            this.ktunnusLB.TabIndex = 0;
            this.ktunnusLB.Text = "Käyttäjätunnus:";
            // 
            // kirjauduBT
            // 
            this.kirjauduBT.BackColor = System.Drawing.Color.Tomato;
            this.kirjauduBT.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduBT.Location = new System.Drawing.Point(314, 645);
            this.kirjauduBT.Name = "kirjauduBT";
            this.kirjauduBT.Size = new System.Drawing.Size(144, 45);
            this.kirjauduBT.TabIndex = 3;
            this.kirjauduBT.Text = "Kirjaudu";
            this.kirjauduBT.UseVisualStyleBackColor = false;
            this.kirjauduBT.Click += new System.EventHandler(this.kirjauduBT_Click);
            // 
            // kirjausFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(816, 715);
            this.Controls.Add(this.kirjauduBT);
            this.Controls.Add(this.tunnistauduGB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kirjausFM";
            this.Text = "Kirjautumisikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tunnistauduGB.ResumeLayout(false);
            this.tunnistauduGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox tunnistauduGB;
        private System.Windows.Forms.TextBox ssTB;
        private System.Windows.Forms.TextBox ktunnusTB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label ktunnusLB;
        private System.Windows.Forms.Button kirjauduBT;
    }
}

