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
    internal class Odinvtaverne
    {
        public static void Eda()
        {
            string text = "Наш герой: Я бы хотела поужинать. \n" +
                          "Лысый мужик за стойкой: Выбери блюдо из перечня на вон той табличке. \n" +
                          "Список блюд:\n" +
                          "Рубленная летающая капуста 600エ\n" +
                          "Жареная личинка жука крысоеда 250エ\n" +
                          "Тушёный волнистый краб 500エ\n" +
                          "Маринованные сверчки 200エ\n" +
                          "Жареное филе лягушки 450エ\n" +
                          "и так далее";
            Console.WriteLine();
            AnimateText(text);
            Console.ReadKey();
            text = "Наш герой: У меня нет денег, могу я как-то иначе распалатиться?\n" +
                          "Лысый: Конечно, красавица, за отсос хоть жареной лягушантикой угощу.";
            Console.WriteLine();
            AnimateText(text);
            text = "Согласиться(1), отказаться(2)\n";
            Console.WriteLine();
            AnimateText(text);
            int otsos = Convert.ToInt32(Console.ReadLine());
            if (otsos == 1)
            {
                text = "Наш герой: Я согласна. \n" +
                          "Вы заходите за стойку к лысому мужику и оплачиваете ужин, после чего съедаете лягушатинки.";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
            }
            if (otsos == 2)
            {
                text = "Наш герой: Я пожалуй откажусь.\n" +
                          "Лысый: Жаль, может тогда вас интересует что-то кроме еды?";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
            }
            Console.WriteLine("Информация(1), жильё(2)");
            int tavernaodin = Convert.ToInt32(Console.ReadLine());
            if (tavernaodin == 1)
            {
                Infa();
            }
            if (tavernaodin == 2)
            {
                Nochleg();
            }
        }
        public static void Infa()
        {
            string text = "Спросить про город(1), спросить, где можно найти работу(2) \n";
            Console.WriteLine();
            AnimateText(text);
            int tav = Convert.ToInt32(Console.ReadLine());
            if (tav == 1)
            {
                text = "Наш герой: Я бы хотела узнать, что это за город и почему у вас на воротах нет стражи? \n" +
                          "Лысый: Город этот Элкия, а стражи нет, потому что налогов не хватает, плохо сейчас всё в городе...";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
            }
            if (tav == 2)
            {
                text = "Наш герой: Я бы хотела найти работу. \n" +
                          "Лысый: Местные не особо хотят брать на работу чужаков, да и сейчас в городе почти нет работы.";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine("Поужинать(1), жильё(2)");
            int tavernaodin = Convert.ToInt32(Console.ReadLine());
            if (tavernaodin == 1)
            {
                Eda();
            }
            
            if (tavernaodin == 2)
            {
                Nochleg();
            }
        }
        public static void Nochleg()
        {
            string text = "Наш герой: я бы хотела найти ночлег, но денег у меня нет.\n" +
                          "Лысый: Хм.. Если победите меня в 21 очко, то могу предоставить комнату, " +
                          "но если проиграете, будете полностью в моём распоряжении.";
            Console.WriteLine();
            AnimateText(text);
            Console.WriteLine();
            Console.WriteLine("Согласиться(1), отказаться(2).");
            int taverna2 = Convert.ToInt32(Console.ReadLine());
            if (taverna2 == 1)
            {
                text = "Наш герой: Я согласна.\n" +
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
                        text = "Лысатик: Ладно, ты победила, будет тебе комната.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        break;
                    }
                    if (Program.poragenie == 3)
                    {
                        text = "Лысый: Ну что красавица, пора равлекаться.\n" +
                            "Лысый мужик отводит вас в свою комнату и насилует вас до смерти и после смерти кстати тоже.\n" +
                            "Потрачено";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                }
                text = "Вы отправляетесь в свою комнату и ложитесь спать." +
                    "Позравляем, вы прошли игру на плохую концовку. ";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
            }
            else if (taverna2 == 2)
            {
                text = "Наш герой: Нет, на такое я не подписывался.\n" +
                "Лысатик: Ну как пожелаешь, если передумаешь, приходи.";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
                text = "Вечер. Наш герой вышел за город и снова построил небольшой шалаш, где лег спать.";
                Console.WriteLine();
                AnimateText(text);
                Console.ReadKey();
                text = "Ночью к вам проползли змеи, обездвижили своим ядом и насиловали, пока вы не умерли от удовольствия.\n" +
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
