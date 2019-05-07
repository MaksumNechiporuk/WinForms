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
            c.Add(new Circle(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()), col));

            Graphics graphics = CreateGraphics();


            graphics.DrawEllipse(new Pen(col, 20),c[0].x,c[0].y,c[0].rad, c[0].rad);
            c.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            col=colorDialog1.Color;

        }
    }
    public class Circle
    {
      public  int x;
       public int y;
      public  int rad;
        public Color color;
        public Circle(int _x, int _y, int _rad, Color c)
        {
            x = _x;
            y = _y;
            rad = _rad;
            color = c;
        }
    }
}
