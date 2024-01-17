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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double smetka = 0;
            List<string> list = new List<string>();
            if (checkBox1.Checked && int.Parse(txbox1.Text) > 0)
            {
                smetka += 11.50 * int.Parse(txbox1.Text);
                list.Add(txbox1.Text+" "+osnovno_text);
            }
            if (checkBox2.Checked && int.Parse(txbox2.Text) > 0)
            {
                smetka += 10.50 * int.Parse(txbox2.Text);
                list.Add(txbox2.Text +" "+ osnovno_text2);
            }
            if (checkBox3.Checked && int.Parse(txbox3.Text) > 0)
            {
                smetka += 10.40 * int.Parse(txbox3.Text);
                list.Add(txbox3.Text + " " + osnovno_text3);
            }
            if (checkBox4.Checked && int.Parse(txbox4.Text) > 0)
            {
                smetka += 12.80 * int.Parse(txbox4.Text);
                list.Add(txbox4.Text + " " + osnovno_text4);
            }
            if (checkBox5.Checked && int.Parse(txbox5.Text) > 0)
            {
                smetka += 4.80 * int.Parse(txbox5.Text);
                list.Add(txbox5.Text + " " + predqstiq_text);
            }
            if (checkBox6.Checked && int.Parse(txbox6.Text) > 0)
            {
                smetka += 4.30 * int.Parse(txbox6.Text);
                list.Add(txbox6.Text + " " + predqstiq_text2);
            }
            if (checkBox7.Checked && int.Parse(txbox7.Text) > 0)
            {
                smetka += 5.60 * int.Parse(txbox7.Text);
                list.Add(txbox7.Text + " " + predqstiq_text3);

            }
            if (checkBox8.Checked && int.Parse(txbox8.Text) > 0) 
            {
                smetka += 5.00 * int.Parse(txbox8.Text);
                list.Add(txbox8.Text + " " + predqstiq_text4);

            }
            if (checkBox9.Checked && int.Parse(txbox9.Text) > 0)
            {
                smetka += 2.80 * int.Parse(txbox9.Text);
                list.Add(txbox9.Text + " " + salati_text);
            }
            if (checkBox10.Checked && int.Parse(txbox10.Text) > 0) 
            {
                smetka +=3.00 * int.Parse(txbox10.Text);
                list.Add(txbox10.Text + " " + salati_text2);
            }
            if (checkBox11.Checked && int.Parse(txbox11.Text) > 0)
            {
                smetka += 2.50 * int.Parse(txbox11.Text);
                list.Add(txbox11.Text + " " + salati_text3);
            }
            if (checkBox12.Checked && int.Parse(txbox12.Text) > 0)
            {
                smetka += 3.20 * int.Parse(txbox12.Text);
                list.Add(txbox12.Text + " " + salati_text4);
            }
            if (checkBox13.Checked && int.Parse(txbox13.Text) > 0)
            {
                smetka += 0.80 * int.Parse(txbox13.Text);
                list.Add(txbox13.Text + " " + bezalkoholni_text);
            }
            if (checkBox14.Checked && int.Parse(txbox14.Text) > 0)
            {
                smetka += 1.40 * int.Parse(txbox14.Text);
                list.Add(txbox14.Text + " " + bezalkoholni_text2);
            }
            if (checkBox15.Checked && int.Parse(txbox15.Text) > 0)
            {
                smetka += 1.50 * int.Parse(txbox15.Text);
                list.Add(txbox15.Text + " " + bezalkoholni_text3);
            }
            if (checkBox16.Checked && int.Parse(txbox16.Text) > 0)
            {
                smetka += 1.20 * int.Parse(txbox16.Text);
                list.Add(txbox16.Text + " " + bezalkoholni_text4);
            }
            if (checkBox17.Checked && int.Parse(txbox17.Text) > 0)
            {
                smetka += 3.40 * int.Parse(txbox17.Text);
                list.Add(txbox17.Text + " " + alkoholni_text);
            }
            if (checkBox18.Checked && int.Parse(txbox18.Text) > 0)
            {
                smetka += 2.60 * int.Parse(txbox18.Text);
                list.Add(txbox18.Text + " " + alkoholni_text2);
            }
            if (checkBox19.Checked && int.Parse(txbox19.Text) > 0)
            {
                smetka += 5.80 * int.Parse(txbox19.Text);
                list.Add(txbox19.Text + " " + deserti_text);
            }
            if (checkBox20.Checked && int.Parse(txbox20.Text) > 0)
            {
                smetka += 7.00 * int.Parse(txbox20.Text);
                list.Add(txbox21.Text + " " + deserti_text2);
            }
            if (checkBox21.Checked && int.Parse(txbox21.Text) > 0)
            {
                smetka += 6.40 * int.Parse(txbox21.Text);
                list.Add(txbox21.Text + " " + deserti_text3);
            }
            
            
            MessageBox.Show($"{string.Join(Environment.NewLine, list )}\n Вашата сметка е: "+smetka+" лв.");
        }
    }
}
