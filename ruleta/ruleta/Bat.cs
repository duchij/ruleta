using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    class Bat 
    {
        public string Type
        {
            get;set;
        }

        public int Num
        {
            get;set;
        }

        public string Color
        {
            get;set;
        }

        public bool Even
        {
            get;set;
        }

        //public int

        public Bat()
        {

        }


        public void setNumBat(string bat)
        {
            string numStr = bat.Substring(1, bat.Length - 1);
            int num = int.Parse(numStr);

            this.Type = "Numeric";
            this.Num = num;
        }

        public void setColorBat(string bat)
        {
            string colStr = bat.Substring(1, 1);
            this.Type = "Color";
            this.Color = colStr;
        }

        public void setEventBat(string bat)
        {
            string evenStr = bat.Substring(1, 1);
            this.Type = "Even";
            if (evenStr == "P")
            {
                this.Even = true;
            }
            else
            {
                this.Even = false;
            }
        }

        public void setColRowBat(string bat)
        {
            string t = bat.Substring(0, 1);
            string numStr = bat.Substring(1, bat.Length - 1);

            if (t == "c")
            {
                this.Type = "Col";

            }
            else
            {
                this.Type = "Row";
            }

            this.Num = int.Parse(numStr);



        }

        public bool checkRange(int num, int range)
        {
            bool result = false;

            switch (range)
            {
                case 1:
                    if (num >=1 && num <= 18)
                    {
                        result = true;
                    }
                    break;

                case 2:
                    if (num >= 1 && num <= 12)
                    {
                        result = true;
                    }
                    break;

                case 3:
                    if (num >= 13 && num <= 24)
                    {
                        result = true;
                    }
                    break;

                case 4:
                    if (num >= 25 && num <= 36)
                    {
                        result = true;
                    }
                    break;

                case 5:
                    if (num >= 19 && num <= 36)
                    {
                        result = true;
                    }
                    break;

            }

            return result;
        }
    }
}
