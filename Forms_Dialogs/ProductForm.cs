using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Dialogs
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
            Product = new Product();
        }
        public ProductForm(Product product)
        {
            InitializeComponent();

            this.Product = product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTb.Text))
            {
                MessageBox.Show("Enter a product name!");
                return;
            }
            Product.Name = nameTb.Text;
            Product.Price = priceNumeric.Value;
            Product.ProductDate = prodDatePicker.Value;
            Product.Description = descriptionTb.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
