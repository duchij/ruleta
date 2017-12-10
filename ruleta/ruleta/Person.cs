using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ruleta
{

    struct info
    {
        public int num;
        public DateTime time;
        public int bat,bank, aktCredit;
        public string status;
    }

    class Person
    {

        public Dictionary<int,info> history;

        public int credit
        {
            get; set;
        }

        public int bank
        {
            get; set;
        }

        public Person(int credit)
        {
            this.credit = credit;
            this.history = new Dictionary<int, info>();
        }

        public void addCredit(int bank)
        {
            this.credit = +bank;
        }

        public void setBank(int bank)
        {
            if (this.credit - bank <0)
            {
                throw new Exception(String.Format("Nemate uz tolko penazi, Vas aktulny kredit je {0}, vlozte menej...", this.credit));
            }

            this.bank = bank;
        }

        public void setBank(string bank)
        {
            int result = 0;

            string str = bank.Substring(1, bank.Length-1);

            if (!int.TryParse(str, out result))
            {
                throw new Exception("Bank moze byt len cislo, dodrzat format bNum (napr. b100)!!!!");
            }
            this.setBank(result);
        }

        public void subCreddit(int bank)
        {
            if (this.credit - bank < 0)
            {
                this.credit = 0;
            }
            else
            {
                this.credit = this.credit - bank;
            }
        }

        public void setBat(string bat)
        {
            //Regex reg = new Regex()




        }

       


    }
}
