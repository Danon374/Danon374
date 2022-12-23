using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Тестик.мяу
{
    internal class Tablitsa
    {
        public static void Records()
        {
            Console.WriteLine("Введите имя для таблицы рекордов: ");
            string name = Console.ReadLine();
            Console.Clear();

            int index = Text.Test("");

            List<User> users = User.Serializing(name, index);

            Console.WriteLine("Таблица рекордов: ");
            Console.WriteLine(new string('=', 18));

            foreach (User item in users)
            {
                Console.WriteLine($"{item.Name}\t{item.Minute} символов в минуту\t{item.Second} символ в секунду");
            }

            Console.WriteLine("Чтобы пройти тест заново - нажмите Enter");
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                Records();
            }
        }
    }
}
