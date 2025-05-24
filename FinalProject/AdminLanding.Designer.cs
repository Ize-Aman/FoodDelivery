namespace FinalProject
{
    partial class AdminLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLanding));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 152, 240);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(467, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 639);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 444);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(86, 125);
            button1.Name = "button1";
            button1.Size = new Size(259, 58);
            button1.TabIndex = 1;
            button1.Text = "Customers";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 217, 217);
            button2.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(86, 240);
            button2.Name = "button2";
            button2.Size = new Size(259, 58);
            button2.TabIndex = 1;
            button2.Text = "Restaurants";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(86, 350);
            button3.Name = "button3";
            button3.Size = new Size(259, 58);
            button3.TabIndex = 1;
            button3.Text = "Drivers";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 217, 217);
            button4.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(86, 462);
            button4.Name = "button4";
            button4.Size = new Size(259, 58);
            button4.TabIndex = 1;
            button4.Text = "Orders";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 552);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 75);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AdminLanding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 158, 168);
            ClientSize = new Size(1120, 639);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "AdminLanding";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox2;
    }
}