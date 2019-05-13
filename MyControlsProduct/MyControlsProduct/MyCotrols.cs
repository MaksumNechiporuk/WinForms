using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControlsProduct
{
    public partial class MyCotrols : UserControl
    {
        List<Category> categories = null;
        List<Product> products =null;
        public MyCotrols()
        {
            InitializeComponent();
        }

        private void MyCotrols_Load(object sender, EventArgs e)
        {
            categories = new List<Category>()
            {
                new Category{Id=1,Name="Смартфони"},
                new Category{Id=2,Name="Товари для дому"},
                new Category{Id=3,Name="Спорт"},
                new Category{Id=4,Name="Канцтовари"}
            };
            comboBox1.DataSource = categories;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";


            products = new List<Product>()
            {
                new Product{Id=1,Name="Samsung", CategoryId = 1, Category = categories.Where(x=>x.Id==1).FirstOrDefault()},
                new Product{Id=2,Name="Шафа", CategoryId = 2, Category = categories.Where(x=>x.Id==2).FirstOrDefault()},
                new Product{Id=3,Name="Xiaomi", CategoryId = 1, Category = categories.Where(x=>x.Id==1).FirstOrDefault()},
                new Product{Id=4,Name="Бігова доріжка", CategoryId = 3, Category = categories.Where(x=>x.Id==3).FirstOrDefault()}
            };
       

            comboBox2.DataSource = products.Where(x => x.Category == (Category)comboBox1.SelectedItem).ToList();
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;

            if (products != null)
            {
                comboBox2.DataSource = products.Where(x => x.Category == (Category)comboBox1.SelectedItem).ToList();
                comboBox2.ValueMember = "Id";
                comboBox2.DisplayMember = "Name";
            }
        }
    }
  public  class Category
    {
       public int Id { get; set; }

        public string Name { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
