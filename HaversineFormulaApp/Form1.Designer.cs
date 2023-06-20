namespace HaversineFormulaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            latitudine1 = new System.Windows.Forms.TextBox();
            longitudine1 = new System.Windows.Forms.TextBox();
            longitudine2 = new System.Windows.Forms.TextBox();
            latitudine2 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            distanta = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Latitudinea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Longitudinea";
            // 
            // latitudine1
            // 
            latitudine1.Location = new System.Drawing.Point(102, 40);
            latitudine1.Name = "latitudine1";
            latitudine1.Size = new System.Drawing.Size(252, 27);
            latitudine1.TabIndex = 2;
            // 
            // longitudine1
            // 
            longitudine1.Location = new System.Drawing.Point(102, 73);
            longitudine1.Name = "longitudine1";
            longitudine1.Size = new System.Drawing.Size(252, 27);
            longitudine1.TabIndex = 3;
            // 
            // longitudine2
            // 
            longitudine2.Location = new System.Drawing.Point(102, 79);
            longitudine2.Name = "longitudine2";
            longitudine2.Size = new System.Drawing.Size(252, 27);
            longitudine2.TabIndex = 8;
            // 
            // latitudine2
            // 
            latitudine2.Location = new System.Drawing.Point(102, 42);
            latitudine2.Name = "latitudine2";
            latitudine2.Size = new System.Drawing.Size(252, 27);
            latitudine2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 79);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 20);
            label5.TabIndex = 6;
            label5.Text = "Longitudinea";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 45);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Latitudinea";
            // 
            // distanta
            // 
            distanta.Location = new System.Drawing.Point(165, 338);
            distanta.Name = "distanta";
            distanta.Size = new System.Drawing.Size(252, 27);
            distanta.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            button1.ForeColor = System.Drawing.Color.DarkCyan;
            button1.Location = new System.Drawing.Point(23, 336);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 29);
            button1.TabIndex = 12;
            button1.Text = "Calculeaza";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.love_earth2;
            pictureBox1.Location = new System.Drawing.Point(445, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(313, 297);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(latitudine1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(longitudine1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            groupBox1.Location = new System.Drawing.Point(23, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(394, 131);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Coordonate I";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(latitudine2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(longitudine2);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            groupBox2.Location = new System.Drawing.Point(23, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(394, 133);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coordonate II";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            button2.ForeColor = System.Drawing.Color.DarkCyan;
            button2.Location = new System.Drawing.Point(23, 409);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(136, 29);
            button2.TabIndex = 16;
            button2.Text = "Aria";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(788, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(distanta);
            Name = "Form1";
            Text = "Calculator Distanta Haversine";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latitudine1;
        private System.Windows.Forms.TextBox longitudine1;
        private System.Windows.Forms.TextBox longitudine2;
        private System.Windows.Forms.TextBox latitudine2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox distanta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
    }
}
