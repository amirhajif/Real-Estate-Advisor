using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    public class Melk
    {
        protected int id;
        protected int metraj;
        protected string adress;
        protected bool is_rent;
        protected bool is_buy;
        protected double pricepermeter;
        protected double price;
        protected string noe_melk;

        public Melk() { is_rent = false; is_buy = false; }
        public void set_id(int sample) { id = sample; }
        public void set_metraj(int sample) { metraj = sample; }
        public void set_adress(string sample) { adress = sample; }
        public void set_pricepermeter(double sample) { pricepermeter = sample; }

        public void set_price() { price = pricepermeter * metraj; }

        public void change_status_r() { is_rent = true; }
        public void change_status_b() { is_buy = true; }

        public int get_id() { return id; }
        public int get_metraj() { return metraj; }
        public double get_price() { return price; }
        public double get_pricepermeter() { return pricepermeter; }
        public string get_adress() { return adress; }
        public string get_noe_melk() { return noe_melk; }
        public virtual int get_room() { return 0; }
        public bool get_rent_status() { return is_rent; }
        public bool get_buy_status() { return is_buy; }

        public override string ToString() 
        {
            string x = "";
            if (is_buy)
                x = "kharide shode";
            if (is_rent)
                x = "ejare/rahn dade shode";
            if (!is_buy && !is_rent)
                x = "ejare/rahn ya kharide nashode";

            return "id --> " + id.ToString() + "\nmetraj --> " + metraj.ToString() + "\naddress --> " + adress +
            "\nprice per meter --> " + pricepermeter + "\nfinal price --> " + price + "vaziat --> " + x;
        }
    }
}
