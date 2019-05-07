using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDI
{
    public partial class Form1 : Form
    {
        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            foreach (var item in this.Controls)
            {
                if(item is MdiClient)
                {
                    (item as MdiClient).BackColor = Color.Blue;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.MdiChildren[pos].Activate();
            pos++;

        }
    }
}
