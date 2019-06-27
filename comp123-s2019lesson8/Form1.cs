using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp123_s2019lesson8
{
    public partial class Lab08 : Form
    {
        string username { get; set; }
        float age { get; set; }
        public Lab08()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            submit.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void NAME_TextChanged(object sender, EventArgs e)
        {
            submit.Enabled = (NAME.Text.length >= 2) ? true : false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(NameTextBox.Text);
                submit.Enabled = true;
            }
            catch
            {
                submit.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserName = NAME.Text;
            age = float.Parse(NameTextBox.Text);

            outputlabel.Text = NAME.Text + " " + NameTextBox.Text;

            clearform();
        }

        ptivate void clearform()
        {
            NAME.Clear();
            NameTextBox.Clear();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
