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
    public partial class GhararDad : Form
    {
        public GhararDad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }
        int index;

        private void button1_Click(object sender, EventArgs e)
        {
            index = 0;
            bool flag = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;

            button3.Visible = false;

            for (; index < Form1.ml.Count; index++)
                if (Form1.ml[index].get_id() == Convert.ToInt32(textBox1.Text) && !Form1.ml[index].get_buy_status() && !Form1.ml[index].get_rent_status())
                {
                    flag = true;
                    break;
                }

            if (!flag)
                richTextBox1.Text = "\t\t\t\t\t\t\tپیدا نشد یا خریده یا اجاره داده شده";

            if (flag)
            {
                richTextBox1.Text += Form1.ml[index].ToString();

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;

                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;

                button3.Visible = true;

            }
        }
        static bool is_repeated(List<Deals>d , int id)
        {
            if (d.Count == 0)
                return false;

            for (int i = 0; i < d.Count; i++)
                if (d[i].get_id() == id)
                    return true;

            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool flag1 = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true, flag6 = true, flag7 = true,
            flag8 = true, flag9 = true, flag10 = true, flag11 = true, flag12 = true, flag13 = true, flag14 = true;

            Foroshande foroshande = new Foroshande();

            if (textBox2.Text == "")
                flag1 = false;
            if(flag1)
                foroshande.set_name(textBox2.Text);

            if (textBox3.Text == "")
                flag2 = false;
            if(flag2)
                foroshande.set_codemeli(textBox3.Text);

            if (textBox4.Text == "")
                flag3 = false;
            if(flag3)
                foroshande.set_phonenumber(textBox4.Text);

            Moshtari moshtari = new Moshtari();

            if (textBox5.Text == "")
                flag4 = false;
            if(flag4)
                moshtari.set_name(textBox5.Text);

            if (textBox6.Text == "")
                flag5 = false;
            if(flag5)
                moshtari.set_codemeli(textBox6.Text);

            if (textBox7.Text == "")
                flag6 = false;
            if(flag6)
                moshtari.set_phonenumber(textBox7.Text);

            Deals d = new Deals();

            d.set_foroshandeh(foroshande);
            d.set_moshtari(moshtari);
            d.set_melk(Form1.ml[index]);
            d.set_price(Form1.ml[index].get_price());

            int day = 0, month = 0, year = 0;

            if (textBox8.Text == "")
                flag7 = false;
            if(flag7)
            {
                day = Convert.ToInt32(textBox8.Text);
                if (day <= 0 || day > 31)
                    flag8 = false;
            }
            if (textBox9.Text == "")
                flag9 = false;
            if(flag9)
            {
                month = Convert.ToInt32(textBox9.Text);
                if (day == 31 && month >= 7)
                    flag10 = false;
                if (month > 12 || month <= 0)
                    flag10 = false;
            }
            if (textBox10.Text == "")
                flag11 = false;
            if(flag11)
            {
                year = Convert.ToInt32(textBox10.Text);

                if (year < 1300 || year > 1400)
                    flag12 = false;
            }

            Date date = new Date(year, month, day);
            d.set_regdate(date);

            int _id;
            while (true)
            {
                _id = new Random().Next(100, 999);
                if (!is_repeated(Form1.de, _id))
                    break;
            }
            d.set_id(_id);

            if (radioButton1.Checked)
                d.set_noe_deal("خرید");
            if (radioButton2.Checked)
                d.set_noe_deal("رهن");
            if (radioButton3.Checked)
                d.set_noe_deal("اجاره");
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                flag14 = false;

            if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6 && flag7 && flag8 && flag9 &&
                flag10 && flag11 && flag12 && flag13 && flag14)
            {
                if(radioButton1.Checked)
                    Form1.ml[index].change_status_b();

                if (radioButton2.Checked || radioButton3.Checked)
                    Form1.ml[index].change_status_r();

                Form1.de.Add(d);

                MessageBox.Show("با موفقیت ثبت شد\nشناسه معامله:" + _id);

                new GhararDad().ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("اطلاعات ورودی غلط یا فیلد پر نشده");
          
        }
    }
}
