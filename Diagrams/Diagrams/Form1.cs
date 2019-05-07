using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagrams
{
    public partial class Form1 : Form
    {
        List<Circle> c = new List<Circle>();
        int x, y, rad;
        Color col;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();

            graphics.DrawEllipse(new Pen(Color.Red,20),)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            col=colorDialog1.Color;

        }
    }
    public class Circle
    {
        int x;
        int y;
        int rad;
        Color color;
        public Circle(int _x, int _y, int _rad, Color c)
        {
            x = _x;
            y = _y;
            rad = _rad;
            color = c;
        }
    }
}
