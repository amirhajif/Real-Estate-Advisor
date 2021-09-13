using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    public class Deals
    {
        private Foroshande foroshandeh;
        private Moshtari moshtari;
        private Melk melk;
        private Date reg_date;
        private string noe_deal;

        private int id;
        private double price;

        public void set_foroshandeh(Foroshande sample) { foroshandeh = sample; }
        public void set_moshtari(Moshtari sample) { moshtari = sample; }
        public void set_melk(Melk sample) { melk = sample; }
        public void set_regdate(Date sample) { reg_date = sample; }
        public void set_id(int sample) { id = sample; }
        public void set_price(double sample) { price = sample; }
        public void set_noe_deal(string _deal) { noe_deal = _deal; }
        public Foroshande get_foroshandeh() { return foroshandeh; }
        public Moshtari get_moshtari() { return moshtari; }
        public Melk get_melk() { return melk; }
        public Date get_regdate() { return reg_date; }
        public int get_id() { return id; }
        public double get_price() { return price; }
        public string get_info()
        {
            return "name foroshande --> " + foroshandeh.get_name() + "\ncode melli foroshande --> " + foroshandeh.get_codemeli()
            + "\nname moshtari --> " + moshtari.get_name() + "\ncode melli moshtari --> " + moshtari.get_codemeli() +
            "\nid melk --> " + melk.get_id() + "\nprice --> " + price + "\nreg date --> " + reg_date.ToString() +
            "\nnoe moamele --> " + noe_deal;
        }

    }
}
