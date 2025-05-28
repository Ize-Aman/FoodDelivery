namespace FinalProject.Admin_Stuff
{
    partial class Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drivers));
            textBox5 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.SetChildIndex(button6, 0);
            panel1.Controls.SetChildIndex(label2, 0);
            panel1.Controls.SetChildIndex(textBox1, 0);
            panel1.Controls.SetChildIndex(label3, 0);
            panel1.Controls.SetChildIndex(textBox3, 0);
            panel1.Controls.SetChildIndex(label4, 0);
            panel1.Controls.SetChildIndex(textBox4, 0);
            panel1.Controls.SetChildIndex(label1, 0);
            panel1.Controls.SetChildIndex(textBox2, 0);
            panel1.Controls.SetChildIndex(pictureBox1, 0);
            panel1.Controls.SetChildIndex(textBox11, 0);
            panel1.Controls.SetChildIndex(button1, 0);
            panel1.Controls.SetChildIndex(button2, 0);
            panel1.Controls.SetChildIndex(button5, 0);
            panel1.Controls.SetChildIndex(button3, 0);
            panel1.Controls.SetChildIndex(button4, 0);
            panel1.Controls.SetChildIndex(label5, 0);
            panel1.Controls.SetChildIndex(label6, 0);
            panel1.Controls.SetChildIndex(textBox5, 0);
            // 
            // textBox1
            // 
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Size = new Size(99, 30);
            label2.Text = "Driver ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 168);
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(4, 171);
            label1.Size = new Size(117, 30);
            label1.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(505, 111);
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.Size = new Size(74, 30);
            label3.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(505, 165);
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.Size = new Size(71, 30);
            label4.Text = "Salary";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(768, 71);
            pictureBox1.Size = new Size(175, 179);
            // 
            // button4
            // 
            button4.Text = "Total Drivers";
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
            label5.Size = new Size(124, 50);
            label5.Text = "Drivers";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(153, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 37);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 231);
            label6.Name = "label6";
            label6.Size = new Size(114, 30);
            label6.TabIndex = 13;
            label6.Text = "Last Name";
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 654);
            Name = "Drivers";
            Text = "Drivers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public TextBox textBox5;
        public Label label6;
    }
}