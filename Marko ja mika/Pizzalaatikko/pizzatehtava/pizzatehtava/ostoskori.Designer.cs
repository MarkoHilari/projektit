namespace pizzatehtava
{
    partial class ostoskori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ostoskori));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ostosDG = new System.Windows.Forms.DataGridView();
            this.tilaaBT = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.juomatBT = new System.Windows.Forms.Button();
            this.suljeoBT = new System.Windows.Forms.Button();
            this.pizzaBT = new System.Windows.Forms.Button();
            this.poistariBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yhteensaLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostosDG)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ostoskorisi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 134);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(855, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ostosDG
            // 
            this.ostosDG.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.ostosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ostosDG.Location = new System.Drawing.Point(12, 174);
            this.ostosDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ostosDG.Name = "ostosDG";
            this.ostosDG.RowHeadersWidth = 82;
            this.ostosDG.Size = new System.Drawing.Size(532, 308);
            this.ostosDG.TabIndex = 2;
            this.ostosDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ostosDG_CellContentClick);
            // 
            // tilaaBT
            // 
            this.tilaaBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilaaBT.Location = new System.Drawing.Point(820, 230);
            this.tilaaBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tilaaBT.Name = "tilaaBT";
            this.tilaaBT.Size = new System.Drawing.Size(173, 70);
            this.tilaaBT.TabIndex = 3;
            this.tilaaBT.Text = "Tilaa";
            this.tilaaBT.UseVisualStyleBackColor = true;
            this.tilaaBT.Click += new System.EventHandler(this.tilaaBT_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.pictureBox5);
            this.groupBox9.Controls.Add(this.juomatBT);
            this.groupBox9.Controls.Add(this.suljeoBT);
            this.groupBox9.Controls.Add(this.pizzaBT);
            this.groupBox9.Location = new System.Drawing.Point(28, 509);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(990, 78);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::pizzatehtava.Properties.Resources.koti;
            this.pictureBox5.Location = new System.Drawing.Point(466, 19);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // juomatBT
            // 
            this.juomatBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juomatBT.Location = new System.Drawing.Point(236, 14);
            this.juomatBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.juomatBT.Name = "juomatBT";
            this.juomatBT.Size = new System.Drawing.Size(162, 58);
            this.juomatBT.TabIndex = 2;
            this.juomatBT.Text = "Juomat";
            this.juomatBT.UseVisualStyleBackColor = true;
            this.juomatBT.Click += new System.EventHandler(this.juomatBT_Click);
            // 
            // suljeoBT
            // 
            this.suljeoBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suljeoBT.Location = new System.Drawing.Point(793, 14);
            this.suljeoBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suljeoBT.Name = "suljeoBT";
            this.suljeoBT.Size = new System.Drawing.Size(162, 58);
            this.suljeoBT.TabIndex = 3;
            this.suljeoBT.Text = "Sulje";
            this.suljeoBT.UseVisualStyleBackColor = true;
            this.suljeoBT.Click += new System.EventHandler(this.suljeoBT_Click);
            // 
            // pizzaBT
            // 
            this.pizzaBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaBT.Location = new System.Drawing.Point(31, 14);
            this.pizzaBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pizzaBT.Name = "pizzaBT";
            this.pizzaBT.Size = new System.Drawing.Size(162, 58);
            this.pizzaBT.TabIndex = 1;
            this.pizzaBT.Text = "Pizza Meny";
            this.pizzaBT.UseVisualStyleBackColor = true;
            this.pizzaBT.Click += new System.EventHandler(this.pizzaBT_Click);
            // 
            // poistariBT
            // 
            this.poistariBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistariBT.Location = new System.Drawing.Point(821, 353);
            this.poistariBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poistariBT.Name = "poistariBT";
            this.poistariBT.Size = new System.Drawing.Size(173, 70);
            this.poistariBT.TabIndex = 12;
            this.poistariBT.Text = "Poista tuote";
            this.poistariBT.UseVisualStyleBackColor = true;
            this.poistariBT.Click += new System.EventHandler(this.poistariBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ostoskorisi yhteensä:";
            // 
            // yhteensaLB
            // 
            this.yhteensaLB.AutoSize = true;
            this.yhteensaLB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yhteensaLB.Location = new System.Drawing.Point(641, 353);
            this.yhteensaLB.Name = "yhteensaLB";
            this.yhteensaLB.Size = new System.Drawing.Size(46, 23);
            this.yhteensaLB.TabIndex = 14;
            this.yhteensaLB.Text = "xxx";
            this.yhteensaLB.Visible = false;
            // 
            // ostoskori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pizzatehtava.Properties.Resources.food_and_drink_pizza_pizzas_tomato;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 617);
            this.Controls.Add(this.yhteensaLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poistariBT);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tilaaBT);
            this.Controls.Add(this.ostosDG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ostoskori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ostoskori";
            this.Load += new System.EventHandler(this.ostoskori_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostosDG)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView ostosDG;
        private System.Windows.Forms.Button tilaaBT;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button juomatBT;
        private System.Windows.Forms.Button suljeoBT;
        private System.Windows.Forms.Button pizzaBT;
        private System.Windows.Forms.Button poistariBT;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yhteensaLB;
    }
}