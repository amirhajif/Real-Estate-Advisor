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
    public partial class ShowMelk : Form
    {
        public ShowMelk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void ShowMelk_Load(object sender, EventArgs e)
        {
            if (Form1.ml.Count == 0)
                richTextBox1.Text = "\t\t\t\t\tرکوردی برای نمایش وجود ندارد";
            else
            {
                for (int i = 0; i < Form1.ml.Count; i++)
                        richTextBox1.Text += Form1.ml[i].ToString() + "\n";
            }
        }
    }
}
