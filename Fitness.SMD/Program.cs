using Fitness.BL.Controller;
using Fitness.BL.Model;
using System;

namespace Fitness.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет - это приложение сделал Я!");

            Console.WriteLine("Введиет имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес");
            var weigth = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weigth, height);
            userController.Save();




        }
    }
}
