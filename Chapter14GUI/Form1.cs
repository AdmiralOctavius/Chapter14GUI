using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter14GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello I am a label");
        }
        private void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Hello I am boi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a chicken wing");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            var osender = sender as CheckBox;
            if(osender.Name == "checkBox1")
            {
                label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }
    }
}
