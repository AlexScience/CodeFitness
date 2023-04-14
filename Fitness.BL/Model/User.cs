using System;


namespace Fitness.BL.Model
{
    public class User
    {
        public string Name { get; } //Имя

        public Gender Gender { get; } //Пол

        public DateTime BirthDate { get; } //Дата Рождения

        public double Weight { get; set; } //Вес

        public double Height { get; set; } //Рост

        public User(string name, Gender gender, DateTime birthDate,
                    double weight, double height)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException();
            }
            if (Gender == null)
            {

            }
            if (birthDate < DateTime.Parse("01.01.1923"))
            {

            }
            if (weight <= 0)
            {

            }
            if (height <= 0)
            {

            }
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }


    }
}
