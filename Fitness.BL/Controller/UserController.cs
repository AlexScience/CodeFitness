using Fitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Controller
{
    public class UserController
    {
        public User User { get; }
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);


        }

        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

            }
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);

            }
        }

    }
}
