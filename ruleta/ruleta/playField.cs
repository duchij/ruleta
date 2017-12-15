using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Text.RegularExpressions;

namespace ruleta
{
       
    class playField
    {


        private Bat bt;

        private string colors = "n,r,b,r,b,r,b,r,b,r,b,b,r,b,r,b,r,b,r,r,b,r,b,r,b,r,b,r,b,b,r,b,r,b,r,b,r";

        private string[] rules = new string[] { @"^s[0-3]?[0-6]$","sR","sB","sP","sN","^c[1-3]$","^r[1-5]$" }; 

        private Policko[] field;

        public playField()
        {
            this.field = new Policko[37];

            //this.fillPlayField();

            this.bt = new Bat();
        }

        public void fillPlayField()
        {
            string[] ha = this.colors.Split(',');
            int c = ha.Length;

            for (int i=0; i < c; i++)
            {
                this.field[i].num = i;
                this.field[i].color = ha[i];

                this.field[i].even = (i % 2 == 0) ? true : false;

                if (i == 0)
                {
                    this.field[i].col = 0;
                }
                else if (i >= 1 && i <= 3)
                {
                    this.field[i].col = i;
                }
                else 
                {
                    if (i % 3 == 0)
                    {
                        this.field[i].col = 3;
                    }
                    else if ((i - 1) % 3 == 0)
                    {
                        this.field[i].col = 1;
                    }
                    else
                    {
                        this.field[i].col = 2;
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
                    
                    switch (t)
                    {
                        case 0:
                            bt.setNumBat(bat);
                            break;
                        case 1:
                            bt.setColorBat(bat);
                           break;
                        case 2:
                            bt.setColorBat(bat);
                            break;
                        case 3:
                            bt.setEventBat(bat);
                            break;
                        case 4:
                            bt.setEventBat(bat);
                            break;
                        case 5:
                            bt.setColRowBat(bat);
                            break;
                        case 6:
                            bt.setColRowBat(bat);
                            break;
                    }
                    
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

        public int runRulet()
        {
            //ball b = new ball();
            Console.WriteLine("rien ne va plus......");
            Thread.Sleep(1000);
            return ball.runBall();
        }



        public bool checkResult(int num)
        {

            bool result = false;

            bool even = this.field[num].even;
            int col = this.field[num].col;
            string color = this.field[num].color;


            switch (bt.Type)
            {
                case "Numeric":
                   result =  (num == bt.Num) ? true:false;
                    break;
                case "Color":
                    result = (color == bt.Color) ? true : false;
                    break;
                case "Even":
                    result = (even == bt.Even) ? true : false;
                    break;
                case "Col":
                    result = (col == bt.Num) ? true : false;
                    break;
                case "Row":
                    result = bt.checkRange(num, bt.Num);
                    break;

            }

            return result;
        }


        public string getColor(string color)
        {

            string result = "";

            if (color == "r")
            {
                result = lang1.r;
            }
            else if (color == "b")
            {
                result = lang1.b;
            }
            else
            {
                result = lang1.n;
            }

            return result;
        }
        //public setBat



    }
}
