using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form2 : Form
    {
        Form1 f1; public Form2 _f2;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f1.Send(_f2, this);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
                f1.Send(_f2, this);

        }
    }
}
