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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Melk> ml = new List<Melk>();
        public static List<Deals> de = new List<Deals>();

        private void button1_Click(object sender, EventArgs e)
        {
            new AddMelk().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SearchMelk().ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new GhararDad().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ShowMelk().ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ShowDeals().ShowDialog();
            this.Close();
        }
    }
}
