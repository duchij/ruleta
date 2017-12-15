using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;



namespace ruleta
{
    class Program
    {
        
        static void Main(string[] args)
        {
            playField field = new playField();
            field.fillPlayField();
            string input = "";

            Person hrac = new Person(100);

           // hrac - 100;

            while (input != "end")
            {

                try
                {
                    Console.WriteLine(lang1.uvod);

                    input = Console.ReadLine();

                    hrac.setBank(input);

                    if (input == "end")
                    {
                        throw new Exception("Koniec");
                    }

                    Console.WriteLine(lang1.pomoc);

                    string bat = Console.ReadLine();

                    if (!field.checkBatFormat(bat))
                    {
                        throw new Exception("Nespravny format zadania stavky, skuste znova....");
                    }

                    //hodime gulicku a toci sa ruleta
                    int res = field.runRulet();
                    //cakame na vysledok

                    //kontrolujeme vysledok
                    bool win = field.checkResult(res);
                    

                    //kvoli diakritike
                    string color = field.getColor(field[res].color);

                    Console.WriteLine(lang1.vypis_stavu, field[res].num, color, field[res].even, field[res].col);

                    //kontrola vyhry
                    if (win)
                    {
                        hrac.addCredit();
                        Console.WriteLine(lang1.win);
                    }                    
                    else
                    {
                        hrac.subCredit();
                        Console.WriteLine(lang1.loose);
                    }

                    hrac.history.Add(String.Format(lang1.history_text,
                                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                        bat,
                                        res,
                                        color,
                                        field[res].even,
                                        (win)?lang1.win:lang1.loose, field[res].col));

                    Console.WriteLine(lang1.actual_credit, hrac.credit);
                    
                   // 
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                  //  Console.ReadLine();
                }
            }

            int cnt = hrac.history.Count;

            for (int i=0; i<cnt; i++)
            {
                Console.WriteLine(hrac.history[cnt - 1 - i]);
            }
            Console.ReadKey();
        }
    }
}
