using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace hentgame
{
    internal class Bitvi
    {
        public static void Sliz()
        {

            int avg = 50;
            int tavg = avg;
            int hp_p = 100;
            int thp_p = hp_p;
            int def_p = 10;
            int tdef_p = def_p;
            int atk_p = 30;
            int tatk_p = atk_p;

            int hp_m = 70;
            int def_m = 15;
            int atk_m = 20;
            string udarm = "";

            while (hp_m > 0 && hp_p > 0)
            {
                Console.WriteLine("Время удара (нажмите Enter)");

                Console.ReadKey();
                Console.WriteLine();
                Random rand = new Random();
                int ran = rand.Next(0, 5);

                if (ran == 0) udarm = "кидает палку";
                if (ran == 1) udarm = "бросается вам в ноги";
                if (ran == 2) udarm = "считает вас мусором и игнорирует";
                if (ran == 3) udarm = "использует палец ярости";
                if (ran == 4) udarm = "плюнул в вас";

                Random rand2 = new Random();
                int ran2 = rand2.Next(0, 4);

                Console.WriteLine("Неожиданно появляется какой-то эффект");

                if (ran2 == 0)
                {
                    tatk_p *= 2;
                    Console.WriteLine("Ваша атака увеличивается в 2 раза");
                }
                if (ran2 == 1)
                {
                    atk_m *= 3;
                    Console.WriteLine("атака монстра увеличивается в 3 раза");
                }
                if (ran2 == 2)
                {
                    Random rand4 = new Random();
                    int ran4 = rand4.Next(5, 20);
                    thp_p += ran4;
                    Console.WriteLine("Вы лечитесь на " + ran4 + " ед. здоровья");
                }
                if (ran2 == 3)
                {
                    Random rand3 = new Random();
                    int ran3 = rand3.Next(5, 20);
                    hp_m += ran3;
                    Console.WriteLine("Монстр лечится на " + ran3 + " ед. здоровья");
                }

                int atk2p = tatk_p - def_m;
                hp_m = hp_m - atk2p;
                int atk2m = atk_m - tdef_p;
                thp_p = thp_p - atk2m;

                Console.WriteLine("Вы бросаете в монстра камень, что валялся под ногами ");
                Console.WriteLine("вы нанесли монстру " + atk2p);
                Console.WriteLine("хп монстра " + hp_m);

                if (hp_m <= 0)
                {
                    Console.WriteLine("Вы победили слайма, ваше хп каким-то чудом восстановилось");
                    tavg = avg; thp_p = hp_p; break;
                }

                Console.ReadKey();

                Console.WriteLine("Монстр " + udarm);
                Console.WriteLine("он нанес вам " + atk2m);
                Console.WriteLine("Ваше хп " + thp_p);

                tdef_p = def_p;
                def_m = 15;
                tatk_p = atk_p;
                atk_m = 20;
                if (thp_p <= 0)
                {
                    Console.WriteLine("Потрачено ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        public static void Succub()
        {
            int avg = 50;
            int tavg = avg;
            int hp_p = 100;
            int thp_p = hp_p;
            int def_p = 10;
            int tdef_p = def_p;
            int atk_p = 30;
            int tatk_p = atk_p;

            int i = 1;
            int hp_succubus = 180;
            int def_succubus = 10;
            int atk_succubus = 25;
            while (i >= 0)
            {
                i++;
                if (Program.mech == true) Console.WriteLine("Нанести удар мечом(1)");
                else Console.WriteLine("Кинуть камень, меча то у тебя нет(1)");
                Console.WriteLine("Подобрать и съесть валяющуюся на земле картошку +30хп(2)");
                string viborhod = Console.ReadLine();
                if (viborhod == "1")
                {
                    int atk3p = tatk_p - def_succubus;
                    hp_succubus = hp_succubus - atk3p;
                    Console.WriteLine("вы нанесли суккубу" + atk3p);
                    Console.WriteLine("хп суккуба " + hp_succubus);
                }
                if (viborhod == "2")
                {
                    thp_p += 30;
                    Console.WriteLine("ваше хп " + thp_p);
                }
                if (viborhod == "1101")
                {
                    Console.WriteLine("Вы всё-таки одолели суккуба, ваше хп каким-то чудом восстановилось");
                    tavg = avg; thp_p = hp_p; break;
                }
                if (hp_succubus <= 0)
                {
                    Console.WriteLine("Вы всё-таки одолели суккуба, ваше хп каким-то чудом восстановилось");
                    tavg = avg; thp_p = hp_p; break;
                }
                if (i % 4 == 0)
                {
                    Console.WriteLine("Суккуб вас целует, излечиваясь на 30 хп");
                    hp_succubus += 30;
                    Console.WriteLine("хп суккуба " + hp_succubus);
                }
                else
                {
                    Console.WriteLine("Суккуб наносит урон");
                    int atk2succubus = atk_succubus - tdef_p;
                    thp_p = thp_p - atk2succubus;
                    Console.WriteLine("вам нанесли " + atk2succubus);
                    Console.WriteLine("ваше хп " + thp_p);
                }


                if (thp_p <= 0)
                {
                    Console.WriteLine("Потрачено ");
                    Environment.Exit(0);
                }

            }
        }
    }
}
