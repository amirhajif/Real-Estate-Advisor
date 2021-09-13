using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoshavereAmlak
{
    public partial class SearchMelk : Form
    {
        public SearchMelk()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "حداکثر قیمت مورد نظر راوارد کنید";
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "تعداد اتاق را وازد کنید";
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "نوع ملک را وارد کنید";
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            if(radioButton1.Checked)
            {
                bool flag = false;
                for (int i = 0; i < Form1.ml.Count; i++)
                {
                    if (Form1.ml[i].get_price() <= Convert.ToInt32(textBox1.Text) && !Form1.ml[i].get_buy_status() && !Form1.ml[i].get_rent_status())
                    {
                        richTextBox1.Text += Form1.ml[i].ToString() + "\n";
                        flag = true;
                    }
                }
                if (!flag)
                    richTextBox1.Text = "\t\t\t\t\tیافت نشد";
            }
            if(radioButton2.Checked)
            {
                bool flag = false;
                for (int i = 0; i < Form1.ml.Count; i++)
                {
                    if (Form1.ml[i].get_room() == Convert.ToInt32(textBox1.Text))
                    {
                        richTextBox1.Text += Form1.ml[i].ToString() + "\n";
                        flag = true;
                    }
                }
                if (!flag)
                    richTextBox1.Text = "\t\t\t\t\tیافت نشد";
            }
            if(radioButton3.Checked)
            {
                bool flag = false;
                for (int i=0; i < Form1.ml.Count; i++)
                {
                    if (Form1.ml[i].get_noe_melk() == textBox1.Text)
                    {
                        richTextBox1.Text += Form1.ml[i].ToString() + "\n";
                        flag = true;
                    }
                }
                if (!flag)
                    richTextBox1.Text = "\t\t\t\t\tیافت نشد";
            }
        }
    }
}
