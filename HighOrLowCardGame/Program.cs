using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighOrLowCardGame
{
    enum Kort1
    {
        SpaderEss = 1,
        SpaderTvå = 2,
        SpaderTre = 3,
        SpaderFyra = 4,
        SpaderFem = 5,
        SpaderSex = 6,
        SpaderSju = 7,
        SpaderÅtta = 8,
        SpaderNio = 9,
        SpaderTio = 10,
        SpaderKnekt = 11,
        SpaderDam = 12,
        SpaderKung = 13,
        HjärterEss = 1,
        HjärterTvå = 2,
        HjärterTre = 3,
        HjärterFyra = 4,
        HjärterFem = 5,
        HjärterSex = 6,
        HjärterSju = 7,
        HjärterÅtta = 8,
        HjärterNio = 9,
        HjärterTio = 10,
        HjärterKnekt = 11,
        HjärterDam = 12,
        HjärterKung = 13,
        RuterEss = 1,
        RuterTvå = 2,
        RuterTre = 3,
        RuterFyra = 4,
        RuterFem = 5,
        RuterSex = 6,
        RuterSju = 7,
        RuterÅtta = 8,
        RuterNio = 9,
        RuterTio = 10,
        RuterKnekt = 11,
        RuterDam = 12,
        RuterKung = 13,
        KlöverEss = 1,
        KlöverTvå = 2,
        KlöverTre = 3,
        KlöverFyra = 4,
        KlöverFem = 5,
        KlöverSex = 6,
        KlöverSju = 7,
        KlöverÅtta = 8,
        KlöverNio = 9,
        KlöverTio = 10,
        KlöverKnekt = 11,
        KlöverDam = 12,
        KlöverKung = 13,
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            
            while (flag)
            {
                
                Console.WriteLine("Gammalt kort = {0}", gammalt);
                Random random = new Random();
                int randomSiffra = random.Next(1, 13);
                //Console.WriteLine(randomSiffra);
                Kort1 nyuppvänt = (Kort1)randomSiffra;
                Console.WriteLine(nyuppvänt);
                Console.ReadLine();
                
                Console.ReadKey();
            }
            flag = Avsluta();
        }

        static string InputHighLow()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine().ToLower();
                    

                    if (input == "higher" || input == "h" || input == "lower" || input == "l") { return input; }
                    else { SkrivUt("Du har angett ett felaktig svar, ange antingen \"Higher\", \"H\" eller \"Lower\" \"L\"."); }
                }catch
                {
                    SkrivUt("Du har angett ett felaktig svar, ange antingen \"Higher\", \"H\" eller \"Lower\" \"L\".");
                }
            }
        }

        static void SkrivUt(string text) { Console.WriteLine(text); }

        static bool Avsluta()
        {
            while (true)
            {
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Escape) { return false; }
                else if (key == ConsoleKey.Enter) { return true; }
            }
        }
    }
}
