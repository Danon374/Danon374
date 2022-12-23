using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестик.мяу
{
    internal class Text
    {
        public static int Test(string textsFile)
        {
            string[] text = new string[7];
            text[0] = "На склонах пригорков, обращенных к югу, уже дымилась первая зелень, я шел, и " +
                "еще казалось, что никакого прошлого нет, никогда не было и быть не может, что прошлое " +
                "просто придумали, и что так называемое прошлое это и есть сам человек, его руки и ноги, " +
                "его тело, сердце и мозг, его опыт, его поле и его небо, и что даже могилы – это живые " +
                "письмена, всегда доступные, говорящие уставшему сердцу о самом сокровенном.";
            text[1] = "В тот ранний весенний день я впервые увидел в руках у школьников букеты свежих, " +
                "чудесных роз. Алых, белых, густо-исчерна-бордовых. Брянская земля и розы? Это было " +
                "нечто совсем уж несовместимое для меня, я знал свою землю всякой истерзанной, залитой " +
                "из конца в конец кровью, в оплывших пожарищах, в виселицах, видел ее дороги, заваленные " +
                "трупами, видел глаза ее детей на иссушенных голодом.";
            text[3] = "Есть разница: стоять на остановке, ожидая автобуса, или мчаться в этом автобусе " +
                "с бешеной скоростью? Есть, разумеется. Но опять-таки относительная; представьте только, " +
                "что ваш автобус мчится-то мчится, но не останавливается. Через полчаса вы так же начнете " +
                "мучиться от движения, как мучились от ожидания. Человек, как известно, скорости не " +
                "ощущает, только ускорение (торможение). Именно в скоростном лифте мы способны на секунду " +
                "или доли секунды испытать момент невесомости.";
            text[4] = "Но они уже взяли дальние приводные станции, и вскоре Анохин вывел самолет на " +
                "посадочную глиссаду. И командир, и правый пилот, и штурман – все они почти одновременно " +
                "разглядели в разлившейся по тундре темени оранжевый прочерк взлетной полосы. Они бы " +
                "узнали ее огненный рисунок из мириад иных земных и небесных огней. Горящий в ночи " +
                "пунктир раздвоился на параллельные цепочки.";
            text[5] = "Были и потом еще встречи, откровенные разговоры, когда появляется ощущение, что " +
                "с души как бы сама собой сползает защитная кожа, и она, ободранная и беззащитная, " +
                "кричит от малейшего прикосновения, но для меня главное уже состоялось там, в маленьком " +
                "брянском безвестном поселке, моем родном поселке Косицы. На судьбу каждого человека в " +
                "нашей стране, если он даже появился на свет уже после, наложила свой неизгладимый " +
                "отпечаток последняя война.";
            text[6] = "В начале войны, в Ленинграде, Дмитрий Дмитриевич Шостакович, как и другие " +
                "ленинградцы, во время воздушных налетов дежурил на крыше. В газетах появилась " +
                "фотография – композитор в брезентовой робе и защитной каске несет вахту. " +
                "Фотография обошла мировую печать. Мне рассказывали, что какой-то богатый американец " +
                "сделал тогда заявление журналистам. «Если, – сказал он, – в России не хватает людей " +
                "для тушения зажигательных бомб.";

            Random rnd = new Random();
            var randomValue = text[rnd.Next(0, text.Length)];
            Console.WriteLine(randomValue);
            Console.WriteLine(new string('=', 31));
            Console.WriteLine("Нажмите Enter для запуска теста");
            Console.SetCursorPosition(0, 0);

            ConsoleKeyInfo key = Console.ReadKey();

            int index = 0;

            if (key.Key == ConsoleKey.Enter)
            {
                Thread timer = new((_) =>
                {
                    Stopwatch stopwatch = new();
                    Stopwatch timer = stopwatch;
                    timer.Start();
                    TimeSpan ts;

                    do
                    {
                        ts = timer.Elapsed;
                        string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                        Console.SetCursorPosition(0, randomValue.Length / Console.WindowWidth+4);
                        Console.WriteLine("Время: " + elapsedTime);
                        Thread.Sleep(1000);

                    } while (ts.Seconds <= 59);

                    Console.SetCursorPosition(0, randomValue.Length / Console.WindowWidth + 5);
                    Console.WriteLine("Стоп!");
                });

                timer.Start();

                do
                {
                    ConsoleKeyInfo Key = Console.ReadKey(true);

                    if (Key.KeyChar == randomValue[index])
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(index, index / Console.WindowWidth);
                        Console.Write(Key.KeyChar);
                        Console.ForegroundColor = ConsoleColor.White;

                        index++;
                    }

                } while (timer.IsAlive);

                Thread.Sleep(900);
                Console.SetCursorPosition(0, randomValue.Length / Console.WindowWidth);
            }

            return index;
        }
    }
}
