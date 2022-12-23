using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестик.мяу
{
    internal class User
    {
        public string Name;
        public int Minute; public float Second;

        public User(string name, int minute)
        {
            Name = name;
            Minute = minute;
            Second = (float)minute / 60;
        }

        public static List<User> Serializing(string name, int index)
        {
            string json = File.ReadAllText("C:\\Users\\79162\\Desktop\\мои фигурки.мяу.txt");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            User user = new User(name, index);
            users.Add(user);

            json = JsonConvert.SerializeObject(users);
            File.WriteAllText("C:\\Users\\79162\\Desktop\\тестик.мяу.json", json);

            return users;
        }
    }
}
