using System.Drawing;
namespace FinalProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 152, 240);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 616);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 206);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(542, 108);
            label1.Name = "label1";
            label1.Size = new Size(137, 36);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(542, 147);
            textBox1.MaximumSize = new Size(300, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 42);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(848, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 52);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(542, 238);
            label2.Name = "label2";
            label2.Size = new Size(129, 36);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(542, 277);
            textBox2.MaximumSize = new Size(300, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 42);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(848, 273);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 52);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(542, 383);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(700, 383);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(137, 48);
            button2.TabIndex = 4;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(542, 481);
            label3.Name = "label3";
            label3.Size = new Size(227, 35);
            label3.TabIndex = 5;
            label3.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(759, 483);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 35);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 158, 168);
            ClientSize = new Size(994, 616);
            this.StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
