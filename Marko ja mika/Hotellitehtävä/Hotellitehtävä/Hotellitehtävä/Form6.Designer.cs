namespace Hotellitehtävä
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lisaa1BT = new System.Windows.Forms.Button();
            this.poista1BT = new System.Windows.Forms.Button();
            this.muokkaa1BT = new System.Windows.Forms.Button();
            this.tyhjenna1BT = new System.Windows.Forms.Button();
            this.huoneTB = new System.Windows.Forms.TextBox();
            this.vapaaTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.huoneTyyppiTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 131);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(387, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Huoneiden hallinta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(801, 471);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Huoneen nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vapaa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puhelin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Huonetyyppi:";
            // 
            // lisaa1BT
            // 
            this.lisaa1BT.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaa1BT.Location = new System.Drawing.Point(41, 426);
            this.lisaa1BT.Name = "lisaa1BT";
            this.lisaa1BT.Size = new System.Drawing.Size(143, 33);
            this.lisaa1BT.TabIndex = 6;
            this.lisaa1BT.Text = "Lisää uusi huone";
            this.lisaa1BT.UseVisualStyleBackColor = true;
            // 
            // poista1BT
            // 
            this.poista1BT.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poista1BT.Location = new System.Drawing.Point(330, 426);
            this.poista1BT.Name = "poista1BT";
            this.poista1BT.Size = new System.Drawing.Size(82, 33);
            this.poista1BT.TabIndex = 7;
            this.poista1BT.Text = "Poista";
            this.poista1BT.UseVisualStyleBackColor = true;
            // 
            // muokkaa1BT
            // 
            this.muokkaa1BT.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaa1BT.Location = new System.Drawing.Point(217, 426);
            this.muokkaa1BT.Name = "muokkaa1BT";
            this.muokkaa1BT.Size = new System.Drawing.Size(82, 33);
            this.muokkaa1BT.TabIndex = 8;
            this.muokkaa1BT.Text = "Muokkaa";
            this.muokkaa1BT.UseVisualStyleBackColor = true;
            // 
            // tyhjenna1BT
            // 
            this.tyhjenna1BT.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjenna1BT.Location = new System.Drawing.Point(269, 491);
            this.tyhjenna1BT.Name = "tyhjenna1BT";
            this.tyhjenna1BT.Size = new System.Drawing.Size(143, 33);
            this.tyhjenna1BT.TabIndex = 9;
            this.tyhjenna1BT.Text = "Tyhjennä kentät";
            this.tyhjenna1BT.UseVisualStyleBackColor = true;
            // 
            // huoneTB
            // 
            this.huoneTB.Location = new System.Drawing.Point(234, 176);
            this.huoneTB.Name = "huoneTB";
            this.huoneTB.Size = new System.Drawing.Size(167, 26);
            this.huoneTB.TabIndex = 10;
            // 
            // vapaaTB
            // 
            this.vapaaTB.Location = new System.Drawing.Point(234, 342);
            this.vapaaTB.Name = "vapaaTB";
            this.vapaaTB.Size = new System.Drawing.Size(167, 26);
            this.vapaaTB.TabIndex = 12;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(234, 285);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(167, 26);
            this.puhelinTB.TabIndex = 13;
            // 
            // huoneTyyppiTB
            // 
            this.huoneTyyppiTB.Location = new System.Drawing.Point(234, 231);
            this.huoneTyyppiTB.Name = "huoneTyyppiTB";
            this.huoneTyyppiTB.Size = new System.Drawing.Size(167, 26);
            this.huoneTyyppiTB.TabIndex = 14;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotellitehtävä.Properties.Resources.hotelli1;
            this.ClientSize = new System.Drawing.Size(1257, 603);
            this.Controls.Add(this.huoneTyyppiTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.vapaaTB);
            this.Controls.Add(this.huoneTB);
            this.Controls.Add(this.tyhjenna1BT);
            this.Controls.Add(this.muokkaa1BT);
            this.Controls.Add(this.poista1BT);
            this.Controls.Add(this.lisaa1BT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lisaa1BT;
        private System.Windows.Forms.Button poista1BT;
        private System.Windows.Forms.Button muokkaa1BT;
        private System.Windows.Forms.Button tyhjenna1BT;
        private System.Windows.Forms.TextBox huoneTB;
        private System.Windows.Forms.TextBox vapaaTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox huoneTyyppiTB;
    }
}