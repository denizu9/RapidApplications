using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          string message = "Welcome " + textBox1.Text.Trim() + " To Site";
            MessageBox.Show(message, "Welcome Dialog", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            DialogResult result = MessageBox.Show(message, "Welcome Dialog", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            BackColor = result.Equals(DialogResult.OK) ? Color.Aquamarine : Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory =  @"C:\";
            openFileDialog.Filter = "Text Files |*.txt|All file |*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK);
        }
    }
}
