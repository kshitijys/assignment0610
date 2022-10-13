using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment0610
{
    public class Count
    {
        public int number  { get; set; }
        public int no = 0;
        public int count = 0;

        public void coutr()
        {
            while(no > 0)
            {
                no = no /= 10;
                count++;
            }
        }
        public override string ToString ()
        {
            return $" no of digits are {count}";
        }



    }
}
