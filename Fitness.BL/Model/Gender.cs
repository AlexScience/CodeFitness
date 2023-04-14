﻿using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Gender
    {
        public string Name { get; }

        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }

            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }

}
