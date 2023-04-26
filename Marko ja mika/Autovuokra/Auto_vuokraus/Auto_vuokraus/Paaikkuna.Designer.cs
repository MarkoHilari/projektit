namespace Auto_vuokraus
{
    partial class Paaikkuna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carsBT = new System.Windows.Forms.Button();
            this.kayttajatBT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.asiakkaatBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1621, 198);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pääikkuna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(530, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOISTOVUOKRAUS";
            // 
            // carsBT
            // 
            this.carsBT.BackColor = System.Drawing.Color.LawnGreen;
            this.carsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsBT.Location = new System.Drawing.Point(129, 215);
            this.carsBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsBT.Name = "carsBT";
            this.carsBT.Size = new System.Drawing.Size(202, 48);
            this.carsBT.TabIndex = 7;
            this.carsBT.Text = "Autot";
            this.carsBT.UseVisualStyleBackColor = false;
            this.carsBT.Click += new System.EventHandler(this.carsBT_Click);
            // 
            // kayttajatBT
            // 
            this.kayttajatBT.BackColor = System.Drawing.Color.LawnGreen;
            this.kayttajatBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayttajatBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajatBT.Location = new System.Drawing.Point(1215, 215);
            this.kayttajatBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayttajatBT.Name = "kayttajatBT";
            this.kayttajatBT.Size = new System.Drawing.Size(202, 48);
            this.kayttajatBT.TabIndex = 8;
            this.kayttajatBT.Text = "Käyttäjät";
            this.kayttajatBT.UseVisualStyleBackColor = false;
            this.kayttajatBT.Click += new System.EventHandler(this.kayttajatBT_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(951, 215);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "Palautuneet";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LawnGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(676, 215);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 48);
            this.button4.TabIndex = 10;
            this.button4.Text = "Vuokralla";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // asiakkaatBT
            // 
            this.asiakkaatBT.BackColor = System.Drawing.Color.LawnGreen;
            this.asiakkaatBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asiakkaatBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakkaatBT.Location = new System.Drawing.Point(400, 215);
            this.asiakkaatBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asiakkaatBT.Name = "asiakkaatBT";
            this.asiakkaatBT.Size = new System.Drawing.Size(202, 48);
            this.asiakkaatBT.TabIndex = 11;
            this.asiakkaatBT.Text = "Asiakkaat";
            this.asiakkaatBT.UseVisualStyleBackColor = false;
            this.asiakkaatBT.Click += new System.EventHandler(this.asiakkaatBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LawnGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 882);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1621, 100);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Auto_vuokraus.Properties.Resources.abstract_watercolor_vintage_illustration_md;
            this.pictureBox1.Location = new System.Drawing.Point(262, 280);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Paaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1621, 982);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.asiakkaatBT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.kayttajatBT);
            this.Controls.Add(this.carsBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Paaikkuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paaikkuna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button carsBT;
        private System.Windows.Forms.Button kayttajatBT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button asiakkaatBT;
        private System.Windows.Forms.Panel panel2;
    }
}