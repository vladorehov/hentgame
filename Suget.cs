using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hentgame
{
    internal class Suget
    {
        public static void Game()
        {
            string lilit = Program.lilit;
            bool mech = Program.mech;
            int eris = 0;

            bool dobro = false;
            bool krd = false;
            bool trans = false;
            bool simpsuccubus = false;
            bool strahsuccubus = false;

            int pobeg1 = 35;

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

            int i = 1;
            int hp_succubus = 200;
            int def_succubus = 15;
            int atk_succubus = 30;

            string text = "Вы безработный студент, который попал в другой мир после того, как вас сбил человек на электросамокате.\n" +
                "Перед вами появилось табло с вашими ничтожными характеристиками и с тем, что вы находитесь в Лесу Угнетения.\n" +
                "Но вы не расстраиваетесь и решаете, что в этом мире вы уж не умрёте столь глупо.";
            AnimateText(text);
            Console.ReadKey();
            Console.WriteLine();
            text = "Вы встречаете первого монстра на своем пути. Будете сражаться или трусливо сбежите?\n" +
                "Нажмите 1, чтобы сразиться; 2,чтобы убежать - стоимость: " + pobeg1 + ",у вас " + tavg;
            AnimateText(text);
            Console.WriteLine();
            Console.WriteLine("Ваше хп " + thp_p);
            Console.WriteLine("хп монстра " + hp_m);
            Console.WriteLine("Ваша защита " + tdef_p);
            Console.WriteLine("защита монстра " + def_m);
            Console.WriteLine("Ваш урон " + tatk_p);
            Console.WriteLine("урон монстра " + atk_m);
            Console.WriteLine("Ваша энергия " + tavg + "/" + avg);

            int otvet1 = Convert.ToInt32(Console.ReadLine());            if (otvet1 == 1) Bitvi.Sliz();


            else if (otvet1 == 2)
            {
                tavg = avg - pobeg1;
                text = "Вы успешно убежали от монстра";
                AnimateText(text);
            }
            Console.ReadKey();
            Console.WriteLine();
            text = "Вы проходите через Лес Угнетения и под одним деревом видите труп проткнутый длинным мечом, подобрать меч? (да(1)/нет(2))\n" +
                "Меч страданий \n макс. хп - 10 \n урон + 10 \n макс. энергия - 5";
            AnimateText(text);
            string otvetmech = Console.ReadLine();
            if (otvetmech == "1")
            {
                Program.mech = true;
                mech = true;
                dobro = false;
                atk_p += 10;
                hp_p -= 10;
                avg -= 5;
                tavg = avg;
                thp_p = hp_p;
                tatk_p = atk_p;
                text = "Вы отжали у трупа меч, можете собой гордиться";
                Console.WriteLine();
                AnimateText(text);
            }
            if (otvetmech == "2")
            {
                text = "За отказ осквернять труп, вы получаете навык Добродетель";
                Console.WriteLine();
                AnimateText(text);
                Program.mech = false;
                dobro = true;
            }
            Console.WriteLine();
            text = "Ночь. На выходе из Леса Угнетения вы видете лежащую на земле женщину с рогами, конечно же это суккуб.";
            Console.WriteLine();
            AnimateText(text);
            Console.WriteLine();
            text = "Подойти и проверить спящего демона похоти? (да(1) / нет(2)(требуется навык Добродетель) )";
            Console.WriteLine();
            AnimateText(text);
            string otvetsuccubus = Console.ReadLine();
            if (otvetsuccubus == "2")
            {
                if (dobro == false)
                {
                    text = "У вас нет навыка Добродетель. ";
                    otvetsuccubus = "1";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.WriteLine();
                }
                if (dobro == true)
                {
                    text = "Вы смогли подавить своё любопытство и пошли дальше ";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.WriteLine();
                    text = "Спустя пару часов скитаний вы видете яблоню и бежите полакомиться её плодами, но внезапно вы падаете,\n " +
                        "потеряв яблоню извиду, а ваше тело пронизано шипами. Вы упали в волчью яму. ";
                    Console.WriteLine();
                    AnimateText(text);
                    Environment.Exit(0);
                }

            }
            if (otvetsuccubus == "1" || dobro == false)
            {
                text = "Вы подходите к спящему суккубу и наклоняетесь к ее груди.\n" +
                    "Потрогать грудь(1), убить(2), разбудить(3) ";
                Console.WriteLine();
                AnimateText(text);

                string viborsuccubus = Console.ReadLine();
                if (viborsuccubus == "1")
                {
                    text = "Вы кладёте руку на её грудь и медленно сжимаете, хозяйка груди слегка шевельнулась.\n" +
                    "Вы приспускаете часть одежды с её груди и стискиваете зубами её затвердевший сосок.";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                    Console.WriteLine();

                    text = "Девушка просыпается, и видя что вы делаете, краснеет и начинает кричать.\n" +
                        "Суккуб: Да...Да как ты посмел?! Я сильнейший демон на севере этого королевства! Я убью тебя, извращенец!";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                    text = "Попытаться успокоить(1), сразиться(2)";
                    Console.WriteLine();
                    AnimateText(text);
                    string viborsuccubus3 = Console.ReadLine();
                    if (viborsuccubus3 == "2")
                    {
                        text = "Вы встаёте в стойку из ДжоДжо, приготовившись к битве.\n" +
                        "Суккуб: Я не позволю тебе умереть безболезненно!";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("Ваше хп " + thp_p);
                        Console.WriteLine("хп суккуба " + hp_succubus);
                        Console.WriteLine("Ваша защита " + tdef_p);
                        Console.WriteLine("защита суккуба " + def_succubus);
                        Console.WriteLine("Ваш урон " + tatk_p);
                        Console.WriteLine("урон суккуба " + atk_succubus);
                        Console.WriteLine();

                        Bitvi.Succub();

                        text = "Наш герой: Ну и зачем надо было сражаться? Я всего-то тебя за грудь полапал. \n" +
                            "Суккуб: Тц... Наглый извращенец... ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Сама-то суккуб, почему ты вообще была против? \n" +
                            "Суккуб: ... ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Понятно, суккуб и при этом девственница значит? \n " +
                            "Суккуб: ... ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Ну раз я тебя победил, то теперь будешь путешествовать со мной.\n" +
                            "Суккуб: такого условия не было!";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();//7
                        text = "Наш герой: Сопротивляться ты всё равно уже явно не в силах, так что пошли, вдвоём веселее. \n" +
                            "Суккуб: Я обязательно тебе отомщу..!";
                        Console.WriteLine();
                        AnimateText(text);
                        text = "Погладить её(1), припугнуть(2)";
                        Console.WriteLine();
                        AnimateText(text);
                        String simpnesimp = Console.ReadLine();
                        if (simpnesimp == "1")
                        {
                            text = "Вы гладите девушку меж рожек." +
                                "Суккуб: это не спасёт тебя от моей мести!..";
                            Console.WriteLine();
                            AnimateText(text);
                            simpsuccubus = true;
                        }
                        else if (simpnesimp == "2")
                        {
                            text = "Наш герой: За каждую твою выходку буду отрубать тебе руку или ногу." +
                                "Девушка побледнела, но сделала вид, что не испугалась.";
                            Console.WriteLine();
                            AnimateText(text);
                            strahsuccubus = true;
                        }
                        text = "Утро. После непродолжительного сна наши герои отправились в ближайший город вдоль торгового тракта.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Как говоришь называется город, в который мы идём?\n" +
                            "Суккуб: Не надо говорить так, будто я уже говорила тебе, а ты забыл.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Ну так как он называется?\n" +
                            "Суккуб: Элкия, столица здешнего государства";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Спросить как её зовут(1), спросить сколько ей лет(2)";
                        Console.WriteLine();
                        AnimateText(text);
                        string imold = Console.ReadLine();

                        if (imold == "1")
                        {
                            text = "Наш герой: Кстати , а как тебя зовут?\n" +
                            "Суккуб: Извращенец всё-таки решил узнать моё имя? Так и быть, я Лилит.";
                            Console.WriteLine();
                            AnimateText(text);
                            lilit = "Лилит";
                        }
                        else if (imold == "2")
                        {
                            text = "Наш герой: Ты довольно невысокая, сколько тебе лет?\n" +
                            "Суккуб: Тц.. Сначала полапал, а потом спрашиваешь, сколько мне лет?! " +
                            "Ну 14 мне, теперь, зная сколько мне, может отстанешь от меня? ";
                            Console.WriteLine();
                            AnimateText(text);
                            Console.ReadKey();
                            text = "Наш герой: Мама, я педофил...\n" +
                                "Суккуб: Что ты там бормочишь, извращенец?";
                            Console.WriteLine();
                            AnimateText(text);
                        }
                        Console.ReadKey(); //9
                        text = "Наши герои спустя несколько часов всё-таки дошли до города.\n" +
                            "Наш герой: Чего-то ни стражи на воротах, ни заполненных людьми улиц, это точно столица?";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = lilit + ": Хочешь больше знать, накорми меня!\n" +
                            "Наш герой: Я сейчас спермой тебя накормлю, говори давай. ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = lilit + ": Мне уже без разницы, снимай штаны.\n" +
                            "Наш герой: Ну давай хотя бы не на улице, там дальше табличка с нарисованной кроватью, " +
                            "наверняка это здешняя альтернатива гостиницы!";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = lilit + ": Я не знаю, что такое гостиница, но такая табличка вешается у таверны, там можно поесть и найти жульё. \n" +
                            "Наш герой: Ты хотела сказать жильё?.. ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = lilit + ": Жильё тоже, и нет, я всё правильно сказала. \n" +
                            "Наш герой: Ладно... Но где-то поселиться нам надо, потому пошли. ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Парень с демоницей заходят в таверну и подходят к, как им показалось, к владельцу сея заведения. \n" +
                            "Лысый мужик за стойкой: Комната на двоих 2000 эрис в день.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Но мы же ещё не спросили... \n" +
                            "Лысый мужик за стойкой: (с усмешкой) А что ещё может понадобиться парню, пришедшему в таверну с суккубом?  ";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("Поужинать(1), информация(2), согласиться(3)");
                        int taverna = Convert.ToInt32(Console.ReadLine());
                        if (taverna == 1)
                        {
                            text = "Наш герой: ну например поужинать? \n" +
                            "Лысый мужик за стойкой: Ну хорошо, выберите блюдо из перечня на вон той табличке. \n" +
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
                            text = "Наш герой: Пс, у тебя ж есть деньги? \n" +
                            lilit + ": мало того, что извращенец, так ещё и бомж...";
                            Console.WriteLine();
                            AnimateText(text);
                            Console.ReadKey();
                            text = "Девушка заказывает себе тушёного крабика, оказывается он синего цвета, \n" +
                                "и после трапезы к вам похдодит тот лысатик";
                            Program.eda = true;
                            Console.WriteLine();
                            AnimateText(text);
                            Console.ReadKey();
                            text = "Лысатик: Теперь вы попросите комнату, так ведь?";
                            Console.WriteLine();
                            AnimateText(text);

                            Igraochko.KonecKomnata();
                        }
                        if (taverna == 2)
                        {
                            text = "Наш герой: Как насчёт информации?\n" +
                                "Лысатик: Извини, информацией не торгую";
                            Console.WriteLine();
                            AnimateText(text);
                            Console.ReadKey();
                            text = "Наш герой: Так и быть, давай поселимся.";
                            Console.WriteLine();
                            AnimateText(text);

                            Igraochko.KonecKomnata();
                        }
                        if (taverna == 3)
                        {
                            text = "Наш герой: Ладно, ты прав.";
                            Console.WriteLine();
                            AnimateText(text);

                            Igraochko.KonecKomnata();
                        }
                    }
                    if (viborsuccubus3 == "1")
                    {
                        text = "Наш герой: Прости, что полапал, давай будем друзьями.\n" +
                            "Суккуб наносит вам удар промеж ног, и с пеной у рта вы падаете замертво.\n" +
                            "Потрачено";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                }
                if (viborsuccubus == "2")
                {
                    if (Program.mech == true)
                    {
                        text = "Вы пронзаете грудь девушки своим мечом. От этого суккуб просыпается и лишь \n" +
                            "успевает спросить: \"За что..?\" ";
                        Console.WriteLine();
                        AnimateText(text);
                    }
                    if (Program.mech == false)
                    {
                        text = "Вы думаете чем её убить и находите большой камень. Взяв его, вы бьёте им по голове девушке. \n" +
                            "Слегка дёрнувшись, суккуб умирает. ";
                        Console.WriteLine();
                        AnimateText(text);
                        if (dobro == true)
                        {
                            text = "За убийство без веских причин вы теряете навык Добродетель";
                            Console.WriteLine();
                            AnimateText(text);
                            dobro = false;
                        }
                    }
                    text = "За убийство демона вы получаете навык Убийца демонов.";
                    Console.WriteLine();
                    AnimateText(text);
                    krd = true;
                    text = "На вас наложено проклятье суккуба Развратное Тело.";
                    Console.WriteLine();
                    AnimateText(text);
                    trans = true;
                    text = "Ваше тело меняет пол, обретая большую грудь.\n" +
                        "Попробовать новые ощущения в женском теле(1), наконец-то поспать(2).";
                    Console.WriteLine();
                    AnimateText(text);
                    string vibortrans = Console.ReadLine();
                    if (vibortrans == "1")
                    {
                        text = "Вы лапаете свою новую грудь, начинаете трогать место, где раньше был ваш экскалибур \n " +
                            "и через пару минут умираете от слишком бурного оргазма.";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                    if (vibortrans == "2")
                    {
                        text = "Вы оттаскиваете труп девушки в кусты, а сами ложитесь спать в сделанном за пару минут шалаше из веток.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();//11
                        text = "Утро. Вы отправились вдоль широкого тракта, замеченного вчера.\n" +
                            "На пути вам встречаются разные деревья, кусты, не густо в общем.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Примерно через час в дороге, вы чувствуете, что вашу ногу начало что-то стискивать.\n" +
                            "Это оказались щупальца, тянущиеся со стороны деревьев";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Они прижали вас к дереву и продолжали опутывать ваше тело";
                        Console.WriteLine();
                        AnimateText(text);
                        text = "Попробовать выбраться(1), пускай продолжают, наверняка будет приятно(2).";
                        Console.WriteLine();
                        AnimateText(text);
                        string tentakli = Console.ReadLine();
                        if (tentakli == "1")
                        {
                            if (Program.mech == true)
                            {
                                text = "Вы разрубаете щупальца мечом, выбираясь из пут и продолжая идти вдоль тракта.\n" +
                                "Вы видите, как из за деревьвьев вылетает небольшая птица с тентаклями. ";
                                Console.WriteLine();
                                AnimateText(text);
                                Console.ReadKey();
                            }
                            else
                            {

                                text = "Ой, а кто это не взял себе меч, да это же наш герой...";
                                Console.WriteLine();
                                AnimateText(text);
                                Console.ReadKey();
                                text = "тентакли продолжали ползти, пробираясь в укромные места вашего женского тела.\n" +
                                "В итоге вы умерли от сильнейшего оргазма после двойного проникновения";
                                Console.WriteLine();
                                AnimateText(text);
                                Console.WriteLine();
                                Console.WriteLine("Потрачено");
                                Environment.Exit(0);
                            }
                        }
                        if (tentakli == "2")
                        {
                            text = "Вы решили не сопротивляться и тентакли продолжали ползти, пробираясь в укромные места вашего женского тела.\n" +
                                "В итоге вы умерли от сильнейшего оргазма после двойного проникновения";
                            Console.WriteLine();
                            AnimateText(text);
                            Console.WriteLine("Потрачено");
                            Environment.Exit(0);
                        }
                        text = "Через ещё несколько часов, вы видете на горизонте город и решаете придавить темп.\n" +
                            "Придя в город у вас было лишь 2 мысли: \"как хорошо, что я ещё жив\" и \"как же хочется есть\".";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "По вилению судьбы, почти сразу после входа в город, вы видете вывеску похожую на обозначение таверны.\n" +
                            "Вы заходите туда и видете лысого мужика за стойкой, похожего на хозяина сея заведения.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Лысый мужик за стойкой: Что такой красавице понадобилось в нашем заведении?";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.WriteLine("Поужинать(1), информация(2), жильё(3)");
                        int tavernaodin = Convert.ToInt32(Console.ReadLine());
                        if (tavernaodin == 1)
                        {
                            Odinvtaverne.Eda();
                        }
                        if (tavernaodin == 2)
                        {
                            Odinvtaverne.Infa();
                        }
                        if (tavernaodin == 3)
                        {
                            Odinvtaverne.Nochleg();
                        }
                    }
                }
                if (viborsuccubus == "3")
                {
                    text = "Вы не громко, но и не тихо просите девушку проснуться. \n" +
                        "Суккуб: Кто ты..? Извращенец..?";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                    text = "наш герой: Неееет... А почему ты спишь в таком месте?..\n" +
                        "Суккуб: Я... Я не справилась со своим предназначением и решила сбежать...";
                    Console.WriteLine();
                    AnimateText(text);
                    Console.ReadKey();
                    text = "Спросить, хочет ли она путешествовать с ним(1), преободрить и наплести чушь ради секса(2)";
                    Console.WriteLine();
                    AnimateText(text);
                    string viborsuccubus2 = Console.ReadLine();
                    if (viborsuccubus2 == "2")
                    {
                        text = "Вы гладите девушку меж рожек и говорите, что она милая.\n" +
                            "Наш герой: Обязанность суккуба ведь состоит в том, чтобы высасывать жизненную силу из мужчин посредством секса?\n" +
                            "Суккуб: ...";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Может я смогу тебе в этом помочь?\n" +
                            "Суккуб: Не.. Не надо...";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Давай я тебе помогу.\n" +
                            "Вы касаетесь её плеча, но девушка вас отталкивает,и вы падаете головой на камень, разбиваясь насмерть";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        Console.WriteLine("Потрачено");
                        Environment.Exit(0);
                    }
                    if (viborsuccubus2 == "1")
                    {
                        text = "Наш герой: Хочешь путешествовать со мной?\n" +
                            "Суккуб: С тобой?.. А куда?..";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Ну, можем отправиться в твою родную страну например.\n" +
                            "Суккуб: Ты хочешь отправиться в страну суккубов?";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Ну а почему нет?\n" +
                            "Суккуб: Ладно.. И всё таки все мужики хотят одного и того же...";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Наш герой: Эй, всё не так!\n" +
                            "Суккуб: Да да.. Ну ладно, я думаю моим сёстрам ты понравишься.";
                        Console.WriteLine();
                        AnimateText(text);
                        Console.ReadKey();
                        text = "Продолжение в спин-оффе \"Невероятные приключения в другом мире с суккубами\".";
                        Console.WriteLine();
                        AnimateText(text);
                        Environment.Exit(0);
                    }
                }
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
