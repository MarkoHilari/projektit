namespace Auto_vuokraus
{
    partial class kayttajat
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.muokkaaKaBT = new System.Windows.Forms.Button();
            this.poistaAsBT = new System.Windows.Forms.Button();
            this.tyhjennaAsBT = new System.Windows.Forms.Button();
            this.lisaaAsBT = new System.Windows.Forms.Button();
            this.sNimiTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.eNimiTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 198);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Auto_vuokraus.Properties.Resources.exit_5871704_1280;
            this.pictureBox1.Location = new System.Drawing.Point(1367, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Käyttäjät";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LawnGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 813);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1497, 100);
            this.panel2.TabIndex = 14;
            // 
            // muokkaaKaBT
            // 
            this.muokkaaKaBT.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaKaBT.Location = new System.Drawing.Point(255, 619);
            this.muokkaaKaBT.Name = "muokkaaKaBT";
            this.muokkaaKaBT.Size = new System.Drawing.Size(142, 59);
            this.muokkaaKaBT.TabIndex = 55;
            this.muokkaaKaBT.Text = "Muokkaa käyttäjää";
            this.muokkaaKaBT.UseVisualStyleBackColor = true;
            this.muokkaaKaBT.Click += new System.EventHandler(this.muokkaaKaBT_Click);
            // 
            // poistaAsBT
            // 
            this.poistaAsBT.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaAsBT.Location = new System.Drawing.Point(443, 619);
            this.poistaAsBT.Name = "poistaAsBT";
            this.poistaAsBT.Size = new System.Drawing.Size(142, 59);
            this.poistaAsBT.TabIndex = 54;
            this.poistaAsBT.Text = "Poista käyttäjä";
            this.poistaAsBT.UseVisualStyleBackColor = true;
            // 
            // tyhjennaAsBT
            // 
            this.tyhjennaAsBT.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaAsBT.Location = new System.Drawing.Point(255, 717);
            this.tyhjennaAsBT.Name = "tyhjennaAsBT";
            this.tyhjennaAsBT.Size = new System.Drawing.Size(142, 59);
            this.tyhjennaAsBT.TabIndex = 53;
            this.tyhjennaAsBT.Text = "Tyhjennä kentät";
            this.tyhjennaAsBT.UseVisualStyleBackColor = true;
            // 
            // lisaaAsBT
            // 
            this.lisaaAsBT.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaAsBT.Location = new System.Drawing.Point(65, 619);
            this.lisaaAsBT.Name = "lisaaAsBT";
            this.lisaaAsBT.Size = new System.Drawing.Size(142, 59);
            this.lisaaAsBT.TabIndex = 52;
            this.lisaaAsBT.Text = "Lisää käyttäjä";
            this.lisaaAsBT.UseVisualStyleBackColor = true;
            this.lisaaAsBT.Click += new System.EventHandler(this.lisaaAsBT_Click);
            // 
            // sNimiTB
            // 
            this.sNimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNimiTB.Location = new System.Drawing.Point(197, 380);
            this.sNimiTB.Name = "sNimiTB";
            this.sNimiTB.Size = new System.Drawing.Size(313, 30);
            this.sNimiTB.TabIndex = 51;
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(197, 289);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(313, 30);
            this.idTB.TabIndex = 48;
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(197, 430);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(313, 30);
            this.emailTB.TabIndex = 47;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinTB.Location = new System.Drawing.Point(197, 473);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(313, 30);
            this.puhelinTB.TabIndex = 46;
            // 
            // eNimiTB
            // 
            this.eNimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNimiTB.Location = new System.Drawing.Point(197, 334);
            this.eNimiTB.Name = "eNimiTB";
            this.eNimiTB.Size = new System.Drawing.Size(313, 30);
            this.eNimiTB.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Puhelin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Sukunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Etunimi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(870, 526);
            this.dataGridView1.TabIndex = 56;
            // 
            // salaTB
            // 
            this.salaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaTB.Location = new System.Drawing.Point(197, 521);
            this.salaTB.Name = "salaTB";
            this.salaTB.Size = new System.Drawing.Size(313, 30);
            this.salaTB.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Salasana:";
            // 
            // kayttajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1497, 913);
            this.Controls.Add(this.salaTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.muokkaaKaBT);
            this.Controls.Add(this.poistaAsBT);
            this.Controls.Add(this.tyhjennaAsBT);
            this.Controls.Add(this.lisaaAsBT);
            this.Controls.Add(this.sNimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.eNimiTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayttajat";
            this.Text = "kayttajat";
            this.Load += new System.EventHandler(this.kayttajat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button muokkaaKaBT;
        private System.Windows.Forms.Button poistaAsBT;
        private System.Windows.Forms.Button tyhjennaAsBT;
        private System.Windows.Forms.Button lisaaAsBT;
        private System.Windows.Forms.TextBox sNimiTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox eNimiTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox salaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}