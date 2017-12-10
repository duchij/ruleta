using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    struct Policko
    {
        public int num
        {
            get; set;
        }

        public string color
        {
            get; set;
        }

        public bool even
        {
            get; set;
        }

        public int row
        {
            get; set;
        }

        public Policko(int num, string color, bool even)
        {
            this.num = num;
            this.color = color;
            this.even = even;

            this.row = 0;
            
            
        }

       


    }
}
