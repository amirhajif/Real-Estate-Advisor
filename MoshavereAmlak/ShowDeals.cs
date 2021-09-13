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
    public partial class ShowDeals : Form
    {
        public ShowDeals()
        {
            InitializeComponent();
        }

        private void ShowDeals_Load(object sender, EventArgs e)
        {
            if (Form1.de.Count == 0)
                richTextBox1.Text = "\t\t\t\t\tرکوردی برای نمایش وجود ندارد";
            else
            {
                for (int i = 0; i < Form1.de.Count; i++)
                    richTextBox1.Text += Form1.de[i].get_info();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }
    }
}
