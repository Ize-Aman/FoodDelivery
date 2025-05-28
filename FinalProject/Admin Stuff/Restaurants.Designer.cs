namespace FinalProject.Admin_Stuff
{
    partial class Restaurants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurants));
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Size = new Size(141, 30);
            label2.Text = "Restaurant ID";
            // 
            // textBox2
            // 
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Size = new Size(71, 30);
            label1.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.Size = new Size(94, 30);
            label3.Text = "Location";
            // 
            // textBox4
            // 
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.Size = new Size(74, 30);
            label4.Text = "Phone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(762, 69);
            pictureBox1.Size = new Size(189, 197);
            // 
            // button4
            // 
            button4.Text = "Total Restaurants";
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Size = new Size(188, 50);
            label5.Text = "Restaurants";
            // 
            // Restaurants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 654);
            Name = "Restaurants";
            Text = "Restaurants";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}