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
    public partial class ParentForm : Form
    {
        ChildForm form = null;

        public ParentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = nameTb.Text;

            // --------- Data from Parent to Child form ---------
            // 1 - using form constructor
            form = new ChildForm(userName);

            // 2 - using property
            form.Email = "example@gmail.com";

            // 3 - using method
            form.SetTitle("Blabla text))");

            // 4 - override method Show or ShowDialog in child form
            form.Show(Color.Azure);

            // --------- Open Form ---------
            //form.Show();              // nomodal mode
            //form.ShowDialog();        // modal mode
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.SetTitle("User Name: " + nameTb.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // --------- Data from Child to Parent form ---------

            // 1 - by putting reference to the child form
            //Product newProduct = new Product();
            //ProductForm form = new ProductForm(newProduct);

            // 2 - by using public property
            ProductForm form = new ProductForm();

            DialogResult result = form.ShowDialog();

            // check result after close
            if (result == DialogResult.OK)
                prodInfoTb.Text = form.Product.ToString();
        }
    }
}
