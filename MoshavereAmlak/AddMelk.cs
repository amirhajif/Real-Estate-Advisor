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
    public partial class AddMelk : Form
    {
        public AddMelk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            richTextBox1.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            richTextBox1.Visible = true;
            label3.Visible = true;
            textBox6.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            richTextBox1.Visible = true;
            label3.Visible = true;
            textBox3.ReadOnly = false;
        }

        public static bool is_repeated(List<Melk>ml,int x)
        {
            if (ml.Count == 0)
                return false;

            for (int i = 0; i < ml.Count; i++)
                if (ml[i].get_id() == x)
                    return true;

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag1 = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true, flag6 = true, flag7 = true;

            int _metraj = 0;
            double _price_per_meter = 0;
            string _address = "";

            if (textBox1.Text == "")
                flag1 = false;
            if(flag1)
            {
                if (textBox1.Text[0] == '-')
                    flag1 = false;
            }
            if(flag1)
                _metraj = Convert.ToInt32(textBox1.Text);

            if (textBox2.Text == "")
                flag2 = false;
            if(flag2)
            {
                if (textBox2.Text[0] == '-')
                    flag2 = false;
            }
            if(flag2)
                _price_per_meter = Convert.ToDouble(textBox2.Text);

            if (richTextBox1.Text == "")
                flag3 = false;
            else
                _address = richTextBox1.Text;

            if(radioButton1.Checked)
            {
                Aparteman ap = new Aparteman();

                ap.set_metraj(_metraj);
                ap.set_pricepermeter(_price_per_meter);
                ap.set_price();
                ap.set_adress(_address);

                int _shomare_tabaghe = 0;
                int _room = 0;

                if (textBox3.Text == "")
                    flag4 = false;
                if(flag4)
                {
                    if (textBox3.Text[0] == '-')
                        flag4 = false;
                }
                if(flag4)
                    _shomare_tabaghe = Convert.ToInt32(textBox3.Text);

                if (textBox4.Text == "")
                    flag5 = false;

                if(flag5)
                {
                    if (textBox4.Text[0] == '-')
                        flag5 = false;
                }

                if(flag5)
                    _room= Convert.ToInt32(textBox4.Text);

                ap.set_shomare_tabaghe(_shomare_tabaghe);
                ap.set_room(_room);

                if (!radioButton4.Checked && !radioButton5.Checked)
                    flag7 = false;

                if (radioButton4.Checked)
                    ap.change_have_elevator();

                int _sen_saze = 0;
                if (textBox5.Text == "")
                    flag6 = false;
                if(flag6)
                {
                    if (textBox5.Text[0] == '-')
                        flag6 = false;
                }

                if(flag6)
                    _sen_saze=Convert.ToInt32(textBox5.Text);

                ap.set_sen_saze(_sen_saze);

                int _id;
                while(true)
                {
                    _id = new Random().Next(100, 999);
                    if (!is_repeated(Form1.ml, _id))
                        break;
                }
                ap.set_id(_id);

                if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6 && flag7)
                {
                    Form1.ml.Add(ap);

                    MessageBox.Show("با موفقیت ثبت شد\nشناسه ملک:" + _id);

                    new AddMelk().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("اطلاعات ورودی نادرست یا کادر خالی");
            }
            if(radioButton2.Checked)
            {
                Vila va = new Vila();

                int _metraje_hayat = 0;
                int _room = 0;
                int _sen_saze = 0;

                va.set_metraj(_metraj);
                va.set_pricepermeter(_price_per_meter);
                va.set_price();
                va.set_adress(_address);

                if (textBox6.Text == "")
                    flag4 = false;

                if(flag4)
                {
                    if (textBox6.Text[0] == '-')
                        flag4 = false;
                }

                if(flag4)
                    _metraje_hayat = Convert.ToInt32(textBox6.Text);

                if (textBox4.Text == "")
                    flag5 = false;
                if(flag5)
                {
                    if (textBox4.Text[0] == '-')
                        flag5 = false;
                }
                if (flag5)
                    _room = Convert.ToInt32(textBox4.Text);

                if (textBox5.Text == "")
                    flag6 = false;
                if(flag6)
                {
                    if (textBox5.Text[0] == '-')
                        flag6 = false;
                }
                if(flag6)
                    _sen_saze = Convert.ToInt32(textBox5.Text);

                va.set_metraj_hayat(_metraje_hayat);
                va.set_room(_room);
                va.set_sen_saze(_sen_saze);

                int _id;
                while (true)
                {
                    _id = new Random().Next(100, 999);
                    if (!is_repeated(Form1.ml, _id))
                        break;
                }
                va.set_id(_id);

                if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6)
                {
                    Form1.ml.Add(va);

                    MessageBox.Show("با موفقیت ثبت شد\nشناسه ملک:" + _id);

                    new AddMelk().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("اطلاعات ورودی نادرست یا کادر خالی");
            }
            if(radioButton3.Checked)
            {
                Tejari tj = new Tejari();

                tj.set_metraj(_metraj);
                tj.set_pricepermeter(_price_per_meter);
                tj.set_price();
                tj.set_adress(_address);

                int _shomare_tabaghe = 0;

                if (textBox3.Text == "")
                    flag4 = false;
                if(flag4)
                {
                    if (textBox3.Text[0] == '-')
                        flag4 = false;
                }
                if(flag4)
                    _shomare_tabaghe = Convert.ToInt32(textBox3.Text);

                tj.set_shomare_tabaghe(_shomare_tabaghe);

                int _id;
                while (true)
                {
                    _id = new Random().Next(100, 999);
                    if (!is_repeated(Form1.ml, _id))
                        break;
                }
                tj.set_id(_id);

                if (flag1 && flag2 && flag3 && flag4) 
                {
                    Form1.ml.Add(tj);

                    MessageBox.Show("با موفقیت ثبت شد\nشناسه ملک:" + _id);

                    new AddMelk().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("اطلاعات ورودی نادرست یا کادر خالی");
            }
        }
    }
}
