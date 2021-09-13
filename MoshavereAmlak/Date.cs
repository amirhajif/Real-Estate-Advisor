using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshavereAmlak
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int y, int m, int d) { day = d; month = m; year = y; }
        public Date() { }
        public override string ToString() { return year.ToString() + "/" + month.ToString() + "/" + day.ToString(); }

    }
}
