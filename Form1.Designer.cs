namespace WindowsFormsApp2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.xo_grid9 = new System.Windows.Forms.PictureBox();
            this.xo_grid8 = new System.Windows.Forms.PictureBox();
            this.xo_grid7 = new System.Windows.Forms.PictureBox();
            this.xo_grid6 = new System.Windows.Forms.PictureBox();
            this.xo_grid5 = new System.Windows.Forms.PictureBox();
            this.xo_grid4 = new System.Windows.Forms.PictureBox();
            this.xo_grid3 = new System.Windows.Forms.PictureBox();
            this.xo_grid2 = new System.Windows.Forms.PictureBox();
            this.xo_grid1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentPlayerLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Player Turn";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(96, 21);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(59, 15);
            this.CurrentPlayerLabel.TabIndex = 0;
            this.CurrentPlayerLabel.Text = "Player 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 17);
            this.panel1.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(224, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Weclome To The Xo Game";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Progress";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.pictureBox10.Location = new System.Drawing.Point(12, 35);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(238, 124);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // xo_grid9
            // 
            this.xo_grid9.Location = new System.Drawing.Point(623, 283);
            this.xo_grid9.Name = "xo_grid9";
            this.xo_grid9.Size = new System.Drawing.Size(111, 110);
            this.xo_grid9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid9.TabIndex = 8;
            this.xo_grid9.TabStop = false;
            this.xo_grid9.Click += new System.EventHandler(this.xo_grid9_Click);
            // 
            // xo_grid8
            // 
            this.xo_grid8.Location = new System.Drawing.Point(465, 283);
            this.xo_grid8.Name = "xo_grid8";
            this.xo_grid8.Size = new System.Drawing.Size(111, 110);
            this.xo_grid8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid8.TabIndex = 7;
            this.xo_grid8.TabStop = false;
            this.xo_grid8.Click += new System.EventHandler(this.xo_grid8_Click);
            // 
            // xo_grid7
            // 
            this.xo_grid7.Location = new System.Drawing.Point(311, 283);
            this.xo_grid7.Name = "xo_grid7";
            this.xo_grid7.Size = new System.Drawing.Size(111, 110);
            this.xo_grid7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid7.TabIndex = 6;
            this.xo_grid7.TabStop = false;
            this.xo_grid7.Click += new System.EventHandler(this.xo_grid7_Click);
            // 
            // xo_grid6
            // 
            this.xo_grid6.Location = new System.Drawing.Point(623, 144);
            this.xo_grid6.Name = "xo_grid6";
            this.xo_grid6.Size = new System.Drawing.Size(111, 110);
            this.xo_grid6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid6.TabIndex = 5;
            this.xo_grid6.TabStop = false;
            this.xo_grid6.Click += new System.EventHandler(this.xo_grid6_Click);
            // 
            // xo_grid5
            // 
            this.xo_grid5.Location = new System.Drawing.Point(465, 144);
            this.xo_grid5.Name = "xo_grid5";
            this.xo_grid5.Size = new System.Drawing.Size(111, 110);
            this.xo_grid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid5.TabIndex = 4;
            this.xo_grid5.TabStop = false;
            this.xo_grid5.Click += new System.EventHandler(this.xo_grid5_Click);
            // 
            // xo_grid4
            // 
            this.xo_grid4.Location = new System.Drawing.Point(311, 144);
            this.xo_grid4.Name = "xo_grid4";
            this.xo_grid4.Size = new System.Drawing.Size(111, 110);
            this.xo_grid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid4.TabIndex = 3;
            this.xo_grid4.TabStop = false;
            this.xo_grid4.Click += new System.EventHandler(this.xo_grid4_Click);
            // 
            // xo_grid3
            // 
            this.xo_grid3.Location = new System.Drawing.Point(623, 3);
            this.xo_grid3.Name = "xo_grid3";
            this.xo_grid3.Size = new System.Drawing.Size(111, 110);
            this.xo_grid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid3.TabIndex = 2;
            this.xo_grid3.TabStop = false;
            this.xo_grid3.Click += new System.EventHandler(this.xo_grid3_Click);
            // 
            // xo_grid2
            // 
            this.xo_grid2.Location = new System.Drawing.Point(465, 3);
            this.xo_grid2.Name = "xo_grid2";
            this.xo_grid2.Size = new System.Drawing.Size(111, 110);
            this.xo_grid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid2.TabIndex = 1;
            this.xo_grid2.TabStop = false;
            this.xo_grid2.Click += new System.EventHandler(this.xo_grid2_Click);
            // 
            // xo_grid1
            // 
            this.xo_grid1.Location = new System.Drawing.Point(311, 3);
            this.xo_grid1.Name = "xo_grid1";
            this.xo_grid1.Size = new System.Drawing.Size(111, 110);
            this.xo_grid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xo_grid1.TabIndex = 0;
            this.xo_grid1.TabStop = false;
            this.xo_grid1.Click += new System.EventHandler(this.xo_grid1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xo_grid9);
            this.Controls.Add(this.xo_grid8);
            this.Controls.Add(this.xo_grid7);
            this.Controls.Add(this.xo_grid6);
            this.Controls.Add(this.xo_grid5);
            this.Controls.Add(this.xo_grid4);
            this.Controls.Add(this.xo_grid3);
            this.Controls.Add(this.xo_grid2);
            this.Controls.Add(this.xo_grid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xo_grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox xo_grid1;
        private System.Windows.Forms.PictureBox xo_grid2;
        private System.Windows.Forms.PictureBox xo_grid3;
        private System.Windows.Forms.PictureBox xo_grid6;
        private System.Windows.Forms.PictureBox xo_grid5;
        private System.Windows.Forms.PictureBox xo_grid4;
        private System.Windows.Forms.PictureBox xo_grid9;
        private System.Windows.Forms.PictureBox xo_grid8;
        private System.Windows.Forms.PictureBox xo_grid7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CurrentPlayerLabel;
    }
}

