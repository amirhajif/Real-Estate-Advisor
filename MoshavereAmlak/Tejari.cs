using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    class Tejari:Melk
    {
        private int Shomare_tabaghe;

        public void set_shomare_tabaghe(int sample) { Shomare_tabaghe = sample; }
        public Tejari() { noe_melk = "تجاری"; }
        public int get_sh_tabaghe() { return Shomare_tabaghe; }
        
        public override string ToString() 
        { 
            return base.ToString() + "\nshomare tabaghe --> " + Shomare_tabaghe.ToString()+
            "\n---------------------\n"; 
        }
    }
}
