namespace AmrahCarApp
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.Mycar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).BeginInit();
            this.CircleProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mycar
            // 
            this.Mycar.BackColor = System.Drawing.Color.Transparent;
            this.Mycar.FillColor = System.Drawing.Color.Black;
            this.Mycar.Image = ((System.Drawing.Image)(resources.GetObject("Mycar.Image")));
            this.Mycar.ImageRotate = 0F;
            this.Mycar.Location = new System.Drawing.Point(36, 22);
            this.Mycar.Margin = new System.Windows.Forms.Padding(4);
            this.Mycar.Name = "Mycar";
            this.Mycar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Mycar.Size = new System.Drawing.Size(137, 110);
            this.Mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mycar.TabIndex = 0;
            this.Mycar.TabStop = false;
            this.Mycar.UseTransparentBackground = true;
            this.Mycar.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // CircleProgressBar1
            // 
            this.CircleProgressBar1.Controls.Add(this.Percentage);
            this.CircleProgressBar1.Controls.Add(this.Mycar);
            this.CircleProgressBar1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.CircleProgressBar1.FillThickness = 8;
            this.CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBar1.Location = new System.Drawing.Point(233, 129);
            this.CircleProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.CircleProgressBar1.Minimum = 0;
            this.CircleProgressBar1.Name = "CircleProgressBar1";
            this.CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar1.Size = new System.Drawing.Size(217, 217);
            this.CircleProgressBar1.TabIndex = 1;
            this.CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.CircleProgressBar1.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(90, 124);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(34, 28);
            this.Percentage.TabIndex = 5;
            this.Percentage.Text = "96";
            this.Percentage.Click += new System.EventHandler(this.Percentage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(241, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "CAR RENTAL SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(265, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "BY SHARBATZADE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(682, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CircleProgressBar1);
            this.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mycar)).EndInit();
            this.CircleProgressBar1.ResumeLayout(false);
            this.CircleProgressBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Mycar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Percentage;
    }
}

