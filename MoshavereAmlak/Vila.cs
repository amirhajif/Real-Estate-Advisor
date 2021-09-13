using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    class Vila:Melk
    {
        private int metraj_hayat;
        private int room;
        private int sen_saze;
        public Vila() { noe_melk = "ویلایی"; }

        public void set_room(int sample) { room = sample; }
        public void set_sen_saze(int sample) { sen_saze = sample; }
        public void set_metraj_hayat(int sample) { metraj_hayat = sample; }

        public override int get_room() { return room; }
        public int get_sen_saze() { return sen_saze; }
        public int get_metraj_hayat() { return metraj_hayat; }

        public override string ToString() 
        {
            return base.ToString() + "\nmetraje hayat --> " + metraj_hayat.ToString() +
            "\nrooms --> " + room.ToString() + "\nsen saze --> " + sen_saze.ToString() + "\n---------------\n";
        }
    }
}
