using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ruleta
{
    class Program
    {
        static void Main(string[] args)
        {

            string colors = "n,r,b,r,b,r,b,r,b,r,b,b,r,b,r,b,r,b,r,r,b,r,b,r,b,r,b,r,b,b,r,b,r,b,r,b,r";

            playField field = new playField();

            field.fillPlayField(colors);
            string input = "";

            Person hrac = new Person(100);

         

           // hrac - 100;

            while (input != "end")
            {

                try
                {
                    Console.WriteLine(@"Zadajte vasu volbu (end = koniec hry, bCislo =  Cislo je vklad napr. 100)"+"\n"+
                                       "ak vlozite Bank uz nemozete z hry oddist....");

                    input = Console.ReadLine();
                    hrac.setBank(input);

                    Console.WriteLine(@"Stavka je napr. sNum = Num cislo 0-36, sR = stavka na cervenu, sB = stavka na ciernu,"+"\n"+
                                       "sP = stavka na parne, sN = stavka na neparne, cN = N=1/2/3 stavka na stlpec."+"\n"+
                                       "stavka na rozsah r1 (1-18), r2 (1-12), r3 (13-24), r4 (25-36), r5 (19-36)" +"\n"+
                                       "Vela stastia...");

                    string bat = Console.ReadLine();

                    if (!field.checkBatFormat(bat))
                    {
                        throw new Exception("Nespravny format zadania stavky, skuste znova....");
                    }

                    
                   // 
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                  //  Console.ReadLine();
                }

            
            }
            
            Console.WriteLine("pole 1:{0}:",field[5].even);
            Console.ReadLine();

        }
    }
}
