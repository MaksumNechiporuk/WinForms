using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYControls
{
    public partial class Valid : UserControl
    {
        public Valid()
        {
            InitializeComponent();
            FValid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FValid();
        }
        void FValid()
        {
            if (textBox1.Text == "")
                label1.Text = "Empty";
            else
                label1.Text = "";
        }
    }
}
