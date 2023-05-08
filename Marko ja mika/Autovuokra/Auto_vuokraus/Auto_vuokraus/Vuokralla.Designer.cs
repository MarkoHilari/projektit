namespace Auto_vuokraus
{
    partial class Vuokralla
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.asiakkaatBT = new System.Windows.Forms.Button();
            this.kayttajatBT = new System.Windows.Forms.Button();
            this.autotBT = new System.Windows.Forms.Button();
            this.palautuneetBT = new System.Windows.Forms.Button();
            this.vuokrallaDG = new System.Windows.Forms.DataGridView();
            this.radioBT = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuokrallaDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(733, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "LOISTOVUOKRAUS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1993, 139);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(876, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "VUOKRALLA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LawnGreen;
            this.panel2.Controls.Add(this.asiakkaatBT);
            this.panel2.Controls.Add(this.kayttajatBT);
            this.panel2.Controls.Add(this.autotBT);
            this.panel2.Controls.Add(this.palautuneetBT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 917);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1993, 78);
            this.panel2.TabIndex = 19;
            // 
            // asiakkaatBT
            // 
            this.asiakkaatBT.BackColor = System.Drawing.Color.LawnGreen;
            this.asiakkaatBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asiakkaatBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakkaatBT.Location = new System.Drawing.Point(413, 20);
            this.asiakkaatBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asiakkaatBT.Name = "asiakkaatBT";
            this.asiakkaatBT.Size = new System.Drawing.Size(180, 38);
            this.asiakkaatBT.TabIndex = 17;
            this.asiakkaatBT.Text = "Asiakkaat";
            this.asiakkaatBT.UseVisualStyleBackColor = false;
            this.asiakkaatBT.Click += new System.EventHandler(this.asiakkaatBT_Click);
            // 
            // kayttajatBT
            // 
            this.kayttajatBT.BackColor = System.Drawing.Color.LawnGreen;
            this.kayttajatBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayttajatBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajatBT.Location = new System.Drawing.Point(1127, 20);
            this.kayttajatBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayttajatBT.Name = "kayttajatBT";
            this.kayttajatBT.Size = new System.Drawing.Size(180, 38);
            this.kayttajatBT.TabIndex = 14;
            this.kayttajatBT.Text = "Käyttäjät";
            this.kayttajatBT.UseVisualStyleBackColor = false;
            this.kayttajatBT.Click += new System.EventHandler(this.kayttajatBT_Click);
            // 
            // autotBT
            // 
            this.autotBT.BackColor = System.Drawing.Color.LawnGreen;
            this.autotBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autotBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autotBT.Location = new System.Drawing.Point(658, 20);
            this.autotBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autotBT.Name = "autotBT";
            this.autotBT.Size = new System.Drawing.Size(180, 38);
            this.autotBT.TabIndex = 16;
            this.autotBT.Text = "AUTOT";
            this.autotBT.UseVisualStyleBackColor = false;
            this.autotBT.Click += new System.EventHandler(this.autotBT_Click);
            // 
            // palautuneetBT
            // 
            this.palautuneetBT.BackColor = System.Drawing.Color.LawnGreen;
            this.palautuneetBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.palautuneetBT.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palautuneetBT.Location = new System.Drawing.Point(902, 20);
            this.palautuneetBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palautuneetBT.Name = "palautuneetBT";
            this.palautuneetBT.Size = new System.Drawing.Size(180, 38);
            this.palautuneetBT.TabIndex = 15;
            this.palautuneetBT.Text = "Palautuneet";
            this.palautuneetBT.UseVisualStyleBackColor = false;
            this.palautuneetBT.Click += new System.EventHandler(this.palautuneetBT_Click);
            // 
            // vuokrallaDG
            // 
            this.vuokrallaDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vuokrallaDG.Location = new System.Drawing.Point(595, 156);
            this.vuokrallaDG.Name = "vuokrallaDG";
            this.vuokrallaDG.RowHeadersWidth = 51;
            this.vuokrallaDG.RowTemplate.Height = 24;
            this.vuokrallaDG.Size = new System.Drawing.Size(751, 514);
            this.vuokrallaDG.TabIndex = 20;
            this.vuokrallaDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vuokrallaDG_CellClick);
            this.vuokrallaDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vuokrallaDG_CellContentClick);
            // 
            // radioBT
            // 
            this.radioBT.AutoSize = true;
            this.radioBT.Location = new System.Drawing.Point(676, 716);
            this.radioBT.Name = "radioBT";
            this.radioBT.Size = new System.Drawing.Size(103, 20);
            this.radioBT.TabIndex = 21;
            this.radioBT.TabStop = true;
            this.radioBT.Text = "radioButton1";
            this.radioBT.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Auto_vuokraus.Properties.Resources.dasse;
            this.pictureBox1.Location = new System.Drawing.Point(64, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Vuokralla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1993, 995);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioBT);
            this.Controls.Add(this.vuokrallaDG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Vuokralla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuokralla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vuokralla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vuokrallaDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button asiakkaatBT;
        private System.Windows.Forms.Button kayttajatBT;
        private System.Windows.Forms.Button autotBT;
        private System.Windows.Forms.Button palautuneetBT;
        private System.Windows.Forms.DataGridView vuokrallaDG;
        private System.Windows.Forms.RadioButton radioBT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}