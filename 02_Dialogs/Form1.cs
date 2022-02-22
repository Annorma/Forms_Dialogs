using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Folder: " + dialog.SelectedPath);
            }
        }*/

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                richTextBox1.SelectionFont = dialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                richTextBox1.SelectionColor = dialog.Color;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*|RTF Files (*.rft)|*.rtf|PDF Files (*.pdf)|*.pdf";
            //dialog.Multiselect = true;
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(dialog.FileName);
                richTextBox1.Text = text;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.DefaultExt = ".rtf";
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //File.WriteAllText(dialog.FileName, richTextBox1.Text);
                richTextBox1.SaveFile(dialog.FileName);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                richTextBox1.BackColor = dialog.Color;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog();

            dialog.ShowDialog();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deselectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}   
