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
    public partial class ChildForm : Form
    {
        public string Email { get; set; }
        public ChildForm(string userName) // parameters to put from parent form
        {
            InitializeComponent();

            nameLabel.Text += " " + userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetTitle(string text)
        {
            this.Text = text;
        }
        public void Show(Color background)
        {
            this.BackColor = background;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Email);
        }
    }
}
