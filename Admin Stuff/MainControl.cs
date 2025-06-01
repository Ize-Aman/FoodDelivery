using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Admin_Stuff
{
    public partial class MainControl : Form
    {
        public MainControl()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button6_Click(object sender, EventArgs e) //clear button
        {
            ClearAllTextBoxes(this);
        }

        private void ClearAllTextBoxes(Control control) //A method for clear button
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                //If the control has children like inside panels
                if (c.HasChildren)
                {
                    ClearAllTextBoxes(c);
                }
            }
        }

    }
}
