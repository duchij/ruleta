using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ruleta
{
    class playField
    {

        private string[] rules = new string[] { @"^s[0-3]?[0-6]$","sR","sB","sP","sN","^c[1-3]$","^r[1-5]$" }; 

        private Policko[] field;

        public playField()
        {
            this.field = new Policko[37];
        }

        public void fillPlayField(string data)
        {
            string[] ha = data.Split(',');
            int c = ha.Length;

            for (int i=0; i < c; i++)
            {
                this.field[i].num = i;
                this.field[i].color = ha[i];

                this.field[i].even = (i % 2 == 0) ? true : false;

                if (i == 0)
                {
                    this.field[i].row = 0;
                }
                else if (i >= 1 && i <= 3)
                {
                    this.field[i].row = i;
                }
                else 
                {
                    if (i % 3 == 0)
                    {
                        this.field[i].row = 3;
                    }
                    else if ((i - 1) % 3 == 0)
                    {
                        this.field[i].row = 1;
                    }
                    else
                    {
                        this.field[i].row = 2;
                    }

                }

            }

        }

        public bool checkBatFormat(string bat)
        {
            Regex reg = null;

            bool res = false;
            int t = 0;
            foreach (string key in rules)
            {
                reg = new Regex(key);
                if (reg.IsMatch(bat))
                {
                    res = true;
                    break;
                }
                t++;
            }

            return res;
        }

        public Policko this[int num]
        {
            get { return this.field[num]; }
            //set { this.field[num].color = value ; this.field[num].num = num; }
        }

        //public setBat



    }
}
