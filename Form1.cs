using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavedenie
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
            int num = int.Parse(textBox1.Text);
            string a = " ";
            string b = " ";
            if (radioButton1.Checked)
            {
                a = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                a = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                b = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                b = radioButton4.Text;
            }
            if (num > 20)
            {
                MessageBox.Show("Nqma tolkova mesta");
                textBox1.Text = "";
            }
            else if (num < 0)
            {
                MessageBox.Show("Invalid amount");
                textBox1.Text = "";
            }
            else
            {
                
                MessageBox.Show("Вие избрахте маса за "+textBox1.Text+", "+a+" ,Плащане с: "+b);
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
