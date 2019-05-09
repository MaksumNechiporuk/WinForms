using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();
        BindingSource binding = new BindingSource();
        int ind = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Width = 820;
                tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 100;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Width = 820;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 50;
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if(ind!=-1)
            {
                people.RemoveAt(ind);
                binding.DataSource = people;
                dataGridView1.DataSource = binding;
            }
        }
        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public Person(string n,string surN,int a)
            {
                Name = n;
                Surname = surN;
                Age = a;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            people.Add(new Person(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text)));
            binding.DataSource = null;

            binding.DataSource = people;
            dataGridView1.DataSource = binding;
            Width = 440;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 0;
             textBox1.Clear();
             textBox2.Clear();
            textBox3.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView1.SelectedRows[0].Index;

        }
    }
}
