namespace Hotellitehtävä
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseHenkilökuntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseVarauksiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseHuoneitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseHenkilökuntaToolStripMenuItem,
            this.hallitseVarauksiaToolStripMenuItem,
            this.hallitseHuoneitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1068, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseHenkilökuntaToolStripMenuItem
            // 
            this.hallitseHenkilökuntaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallitseHenkilökuntaToolStripMenuItem.Name = "hallitseHenkilökuntaToolStripMenuItem";
            this.hallitseHenkilökuntaToolStripMenuItem.Size = new System.Drawing.Size(228, 34);
            this.hallitseHenkilökuntaToolStripMenuItem.Text = "Hallitse henkilökunta";
            // 
            // hallitseVarauksiaToolStripMenuItem
            // 
            this.hallitseVarauksiaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallitseVarauksiaToolStripMenuItem.Name = "hallitseVarauksiaToolStripMenuItem";
            this.hallitseVarauksiaToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.hallitseVarauksiaToolStripMenuItem.Text = "Hallitse varauksia";
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            this.hallitseHuoneitaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            this.hallitseHuoneitaToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.hallitseHuoneitaToolStripMenuItem.Text = "Hallitse huoneita";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 657);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Pääikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallitseHenkilökuntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseVarauksiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
    }
}