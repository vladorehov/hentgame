using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace hentgame
{
    internal class Igraochko
    {
        public static void Ochko()
        {
            int summa = 0;
            int ochkobot = 0;
            Koloda koloda = new Koloda("karti", 1, 1);
            List<Koloda> kolod = new List<Koloda>()
            {
                new Koloda ("шесть", 1, 6),
                new Koloda ("семь", 2, 7),
                new Koloda ("восемь", 3, 8),
                new Koloda ("девять", 4, 9),
                new Koloda ("десять", 5, 10),
                new Koloda ("валет", 6, 2),
                new Koloda ("дама", 7, 3),
                new Koloda ("король", 8, 4),
                new Koloda ("туз", 9, 11),
            };

            BeremKartu();
            BotBeret();
            Console.WriteLine("Лысатик берёт карту");
            BeremKartu();
            Console.WriteLine("Лысатик берёт карту");
            int y = 0;
            while (y == 0)
            {
                Console.WriteLine("Взять ещё карту(1) или вскрываемся(2)");
                int vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor == 1) BeremKartu();
                if (vibor == 2)
                {
                    Console.WriteLine("Лысатик берёт карту");
                    Console.WriteLine("Ваши очки: " + summa);
                    Console.WriteLine("Очки противика: " + ochkobot);
                    if ((summa > ochkobot && summa <= 21) || (summa < ochkobot && ochkobot > 21))
                    {
                        Console.WriteLine("Вы победили");
                        Program.pobeda++;
                    }
                    else if (summa == ochkobot)
                    {
                        Console.WriteLine("Ничья");
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли");
                        Program.poragenie++;
                    }
                    break;
                }
            }
            

            void BeremKartu()
            {
                Console.Write("Вы берете карту ");
                Console.WriteLine();
                Random random = new Random();
                int rand = random.Next(1, 9);
                foreach (var i in kolod)
                {
                    if (i.Nomer == rand)
                    {
                        Console.WriteLine("это " + i.Karti);
                        summa += i.Znach;
                    }
                }
                Console.WriteLine("Сумма ваших очков: " + summa);
            }
            void BotBeret()
            {
                
                Random random = new Random();
                int rand = random.Next(14, 23);
                ochkobot = rand;
            }

            Console.ReadKey();
        }
        public static void KonecKomnata()
        {
            string lilit = Program.lilit;

            string text = lilit + ": За комнату плати сам, извращенец. \n" +  //
            "Наш герой: Но у меня же нет денег, как ты это представляешь?";
            Console.WriteLine();
            AnimateText(text);
            Console.ReadKey();
            text = "Лысатик: Я тут совершенно случайно подслушал, что денег у вас нет, но у меня есть для вас решение.\n" +
            "Наш герой: Ну ещё бы ты в полуметре от нас не подслушал... Так что за предложение? \n" +
            "Лысатик: Сыграем в очко, выигрываете - получаете комнату, проигрываете - становитесь нашими игрушками.\n" +
            lilit + ": Ты ж не вздумал согласиться?...";
            Console.WriteLine();
            AnimateText(text);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Согласиться(1), отказаться(2).");
            int taverna2 = Convert.ToInt32(Console.ReadLine());
            if (taverna2 == 1)
            {
                text = "Наш герой: Мы согласны.\n" +
                lilit + ": Ты ёбнутый?! Все мозги выкончал что ли?!\n" +
                "Лысатик: Отлично, играем до трёх побед!";
                Console.WriteLine();
                AnimateText(text);
                Console.WriteLine();
                Console.ReadKey();
                while (Program.pobeda < 4 || Program.poragenie < 4)
                {
                    Igraochko.Ochko();
                    if (Program.pobeda == 3)
                    {
                        text = "Лысатик: Ладно, вы победили, будет вам комната.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        break;
                    }
                    if (Program.poragenie == 3)
                    {
                        text = "Лысатик: Хах, видимо не судьба вам сегодня спокойно поспать.\n" +
                            "К вам сходится вся таверна, срывает одежду и насилует до смерти.\n" +
                            "Потрачено";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                }
                text = lilit + ": Если бы ты проиграл, я бы сама из тебя чучело сделала!\n" +
                    "Наш герой: Главное вера в победу!";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
                text = "Наша парочка заходит в свою комнату.\n" +
                    "Наш герой: так что насчёт информации о городе?";
                Console.WriteLine();
                AnimateText(text);
                if (Program.eda == true)
                {
                    text = lilit + ": Я уже поела, так что тебе нечего мне предложить.\n" +
                    "Наш герой: Хер с тобой, утром поговорим.";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                    text = "Поздравляем, вы прошли первую часть игры на неплохую концовку.";
                    Console.WriteLine();
                    AnimateText(text);
                    Environment.Exit(0);
                }
                else
                {
                    text = lilit + ": Ладно... Я слишком долго не ела, даже в таверне из-за вашей игры забыла поужинать!\n" +
                    "Наш герой раздевается, и девушка начинает свою трапезу, после окончания которой оба ложатся спать.";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                    if (Program.simpsuccubus == true)
                    {
                        text = "Во сне девушка прижималась к нашему герою и улыбалась, вот же мелкая цундере.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Поздравляем, вы прошли первую часть игры на истинную концовку.";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                    else
                    {
                        text = "Поздравляем, вы прошли первую часть игры на неплохую концовку.";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                }
            }
            else if (taverna2 == 2)
            {
                text = "Наш герой: Мы пожалуй откажемся.\n" +
                lilit + ": Ну хоть мозги у тебя не вытекли...\n" +
                "Лысатик: Ну как пожелаете, если передумаете, приходите.";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
                text = "Вечер. Наши герои вышли за город и нашли небольшую полянку, где легли спать";
                Console.WriteLine();
                AnimateText(text);
                if (Program.simpsuccubus == true)
                {
                    text = "Во сне девушка прижалась к нашему герою, может она просто цундере?";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                }
                text = "Ночью к вам пришли огромные склизкие лягушки и съели вас.\n" +
                "Потрачено";
                Console.WriteLine();
                AnimateText(text);
                Environment.Exit(0);
            }
        }
        static void AnimateText(string text)
        {
            for (int h = 0; h < text.Length; h++)
            {
                Console.Write(text[h]);
                Thread.Sleep(10);
            }
        }
    }
}
