using System;


namespace Fitness.BL.Model
{
    [Serializable]
    public class User
    {
        public string Name { get; } //Имя 

        public Gender Gender { get; set; } //Пол

        public DateTime BirthDate { get; set; } //Дата Рождения

        public double Weight { get; set; } //Вес

        public double Height { get; set; } //Рост

        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }
        }

        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region проверка исключений

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1923") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше 0 или равен 0 ", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше 0 или равен 0 ", nameof(height));
            }

            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name + "" + Age;
        }
    }
}