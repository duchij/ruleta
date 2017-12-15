using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ruleta
{

    
    class Person
    {

        public Dictionary<int, string> history
        {
            get;set;
        }
                
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
            this.history = new Dictionary<int, string>();
            //this.history = new Dictionary<int, info>();
        }


       // public static 
        
        public void addCredit()
        {
            this.credit = +this.bank;
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

            if (bank.Substring(0,1) != "b")
            {
                throw new Exception("Zly format banku");
            }

            if (!int.TryParse(str, out result))
            {
                throw new Exception("Bank moze byt len cislo, dodrzat format bNum (napr. b100)!!!!");
            }
            this.setBank(result);
        }

        public void subCredit()
        {
            if (this.credit - this.bank < 0)
            {
                this.credit = 0;
            }
            else
            {
                this.credit = this.credit - this.bank;
            }
        }

        public void setBat(string bat)
        {
            //Regex reg = new Regex()
        }

       


    }
}
