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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.juomatBT = new System.Windows.Forms.Button();
            this.suljeoBT = new System.Windows.Forms.Button();
            this.pizzaBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostosDG)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ostoskorisi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 168);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(962, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ostosDG
            // 
            this.ostosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ostosDG.Location = new System.Drawing.Point(276, 225);
            this.ostosDG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ostosDG.Name = "ostosDG";
            this.ostosDG.RowHeadersWidth = 82;
            this.ostosDG.Size = new System.Drawing.Size(598, 385);
            this.ostosDG.TabIndex = 2;
            this.ostosDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ostosDG_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(924, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tilaa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(924, 385);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 122);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tyhjennä ostoskori";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.juomatBT);
            this.groupBox9.Controls.Add(this.suljeoBT);
            this.groupBox9.Controls.Add(this.pizzaBT);
            this.groupBox9.Location = new System.Drawing.Point(31, 636);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(1114, 98);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            // 
            // juomatBT
            // 
            this.juomatBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juomatBT.Location = new System.Drawing.Point(471, 17);
            this.juomatBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.juomatBT.Name = "juomatBT";
            this.juomatBT.Size = new System.Drawing.Size(182, 72);
            this.juomatBT.TabIndex = 2;
            this.juomatBT.Text = "Juomat";
            this.juomatBT.UseVisualStyleBackColor = true;
            this.juomatBT.Click += new System.EventHandler(this.juomatBT_Click);
            // 
            // suljeoBT
            // 
            this.suljeoBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suljeoBT.Location = new System.Drawing.Point(892, 17);
            this.suljeoBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suljeoBT.Name = "suljeoBT";
            this.suljeoBT.Size = new System.Drawing.Size(182, 72);
            this.suljeoBT.TabIndex = 3;
            this.suljeoBT.Text = "Sulje";
            this.suljeoBT.UseVisualStyleBackColor = true;
            this.suljeoBT.Click += new System.EventHandler(this.suljeoBT_Click);
            // 
            // pizzaBT
            // 
            this.pizzaBT.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaBT.Location = new System.Drawing.Point(35, 17);
            this.pizzaBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pizzaBT.Name = "pizzaBT";
            this.pizzaBT.Size = new System.Drawing.Size(182, 72);
            this.pizzaBT.TabIndex = 1;
            this.pizzaBT.Text = "Pizza Meny";
            this.pizzaBT.UseVisualStyleBackColor = true;
            this.pizzaBT.Click += new System.EventHandler(this.pizzaBT_Click);
            // 
            // ostoskori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pizzatehtava.Properties.Resources.food_and_drink_pizza_pizzas_tomato;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 771);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ostosDG);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ostoskori";
            this.Text = "ostoskori";
            this.Load += new System.EventHandler(this.ostoskori_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostosDG)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView ostosDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button juomatBT;
        private System.Windows.Forms.Button suljeoBT;
        private System.Windows.Forms.Button pizzaBT;
    }
}