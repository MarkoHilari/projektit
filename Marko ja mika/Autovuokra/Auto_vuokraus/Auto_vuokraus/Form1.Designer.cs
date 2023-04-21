namespace Auto_vuokraus
{
    partial class Loading
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
            this.label1 = new System.Windows.Forms.Label();
            this.loadingGB = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aloPB = new System.Windows.Forms.ProgressBar();
            this.loadingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Ravie", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOISTOVUOKRAUS";
            // 
            // loadingGB
            // 
            this.loadingGB.BackColor = System.Drawing.Color.Transparent;
            this.loadingGB.Controls.Add(this.label1);
            this.loadingGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingGB.Location = new System.Drawing.Point(353, 19);
            this.loadingGB.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.loadingGB.Name = "loadingGB";
            this.loadingGB.Size = new System.Drawing.Size(495, 86);
            this.loadingGB.TabIndex = 1;
            this.loadingGB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aloPB
            // 
            this.aloPB.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aloPB.Location = new System.Drawing.Point(301, 634);
            this.aloPB.Name = "aloPB";
            this.aloPB.Size = new System.Drawing.Size(631, 23);
            this.aloPB.TabIndex = 2;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Auto_vuokraus.Properties.Resources.abstract_watercolor_vintage_illustration_md;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 704);
            this.Controls.Add(this.aloPB);
            this.Controls.Add(this.loadingGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loisto Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.loadingGB.ResumeLayout(false);
            this.loadingGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox loadingGB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar aloPB;
    }
}

