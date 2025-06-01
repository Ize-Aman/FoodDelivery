namespace FinalProject
{
    partial class Restaurant3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurant3));
            ((System.ComponentModel.ISupportInitialize)pictureBoxLazagna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFanta).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLazagna
            // 
            pictureBoxLazagna.Image = (Image)resources.GetObject("pictureBoxLazagna.Image");
            // 
            // labelPriceLazagna
            // 
            labelPriceLazagna.Text = "price;       $7";
            // 
            // comboBoxLasagna
            // 
            comboBoxLasagna.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = (Image)resources.GetObject("pictureBoxPizza.Image");
            // 
            // labelPricePizza
            // 
            labelPricePizza.Text = "price;       $9";
            // 
            // comboBoxPizza
            // 
            comboBoxPizza.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            // 
            // buttonTotal
            // 
            buttonTotal.Click += buttonTotal_Click;
            // 
            // buttonReset
            // 
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // pictureBoxBurger
            // 
            pictureBoxBurger.Image = (Image)resources.GetObject("pictureBoxBurger.Image");
            pictureBoxBurger.Size = new Size(187, 196);
            // 
            // labelBurger
            // 
            labelBurger.Location = new Point(142, 686);
            // 
            // labelPriceBurger
            // 
            labelPriceBurger.Text = "price;       $6";
            // 
            // comboBoxBurger
            // 
            comboBoxBurger.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            // 
            // pictureBoxFanta
            // 
            pictureBoxFanta.Image = (Image)resources.GetObject("pictureBoxFanta.Image");
            pictureBoxFanta.Location = new Point(496, 476);
            pictureBoxFanta.Size = new Size(232, 195);
            // 
            // labelFanta
            // 
            labelFanta.Location = new Point(589, 674);
            // 
            // labelPriceFanta
            // 
            labelPriceFanta.Text = "price;       $3";
            // 
            // comboBoxFanta
            // 
            comboBoxFanta.Items.AddRange(new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            // 
            // Restaurant3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 1050);
            Name = "Restaurant3";
            Text = "Restaurant3";
            Load += Restaurant3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLazagna).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFanta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}