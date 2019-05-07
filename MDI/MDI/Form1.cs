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
    public partial class Form1 : Form
    {
        Form2 f2, f3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f3 = new Form2(this);
            f2.Text = "user 1";
            f3.Text = "user 2";

            f2._f2 = f3;
            f2.MdiParent = this;
            f2.Show();
            f3._f2 = f2;
            f3.MdiParent = this;
            f3.Show();
            f3.Location = new Point(500, 0);
            this.MdiChildren[0].Activate();
            this.MdiChildren[1].Enabled=false;
            btnStart.Enabled = false;
        }

        public void Send(Form2 f1,Form2 f2)
        {
            f1.listBox1.Items.Add(f2.Text+": "+f2.textBox1.Text);
            f2.textBox1.Clear();
            f1.Enabled = true;
            f2.Enabled = false;
            f1.Activate();
        }

    }
}
