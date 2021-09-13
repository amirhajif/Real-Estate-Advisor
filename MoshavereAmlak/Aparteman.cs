using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    class Aparteman:Melk
    {
        private int Shomare_tabaghe;
        private int room;
        private bool have_elevator;
        private int sen_saze;
        public Aparteman() { noe_melk = "آپارتمانی"; have_elevator = false; }
        public void set_shomare_tabaghe(int sample) { Shomare_tabaghe = sample; }
        public void set_room(int sample) { room = sample; }
        public void set_sen_saze(int sample) { sen_saze = sample; }
        public void change_have_elevator() { have_elevator = true; }

        public int get_sh_tabaghe() { return Shomare_tabaghe; }
        public override int get_room() { return room; }
        public int get_sen_saze() { return sen_saze; }
        public bool get_have_elevator() { return have_elevator; }
        public override string ToString() 
        {
            string x = "";

            if (have_elevator)
                x = "have elevator";
            else
                x = "dont have elevator";

            return base.ToString() + "\nshomare tabaghe --> " + Shomare_tabaghe.ToString() +
            "\nrooms --> " + room.ToString() + "\nsen saze --> " + sen_saze.ToString() + "\nelevator --> " + x + "\n-------------------\n";
        }
    }
}
