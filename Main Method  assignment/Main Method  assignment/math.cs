using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method__assignment
{
    class math
    {
        public int Number (int addnumber)
        {
            int total1 = addnumber * 25;
            return total1;
        }

        public int Number (decimal addnumber)
        {
            int total2 = Convert.ToInt32(addnumber) + 25;
            return total2;
        }

        public int Number (string addnumber)
        {
            int total2 = Convert.ToInt32(addnumber) / 10;
            return total2;
        }
    }
}
