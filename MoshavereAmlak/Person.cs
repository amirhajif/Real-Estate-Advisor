using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    public class Person
    {
        protected string name;
        protected string code_meli;
        protected string phone_number;

        public void set_name(string sample) { name = sample; }
        public void set_codemeli(string sample) { code_meli = sample; }
        public void set_phonenumber(string sample) { phone_number = sample; }

        public string get_name() { return name; }
        public string get_codemeli() { return code_meli; }
        public string get_phonenumber() { return phone_number; }
    }
}
