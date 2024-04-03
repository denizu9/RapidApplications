using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File (png)|*.png|Image File (jpg)|*.jpg|All files|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("user cancelled");
                return;
            }

            label2.Text = dialog.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily family in FontFamily.Families)
            {
                comboBox1.Items.Add(family.Name);
            }
        }

        private void changeColor(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
                return;
            string familyName = comboBox1.Text;
            label5.Font = new Font(familyName, 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            textBox1.BackColor = dialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = label2.Text;

            
            richTextBox2.Text = richTextBox1.Text;
            richTextBox2.Font = new Font(comboBox1.Text, 12);
            richTextBox2.ForeColor = comboBox1.ForeColor;

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (textBox3.Text == "denizural9@gmail.com")
            {
                MessageBox.Show("Message Sent!");
            } else
            {
                MessageBox.Show("Message Could Not Send");
            }
           
        }
    }
}
