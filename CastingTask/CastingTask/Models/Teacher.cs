using System;
using System.Collections.Generic;
using System.Text;

namespace CastingTask.Models
{
   class Teacher:Person
    {
        private static int _id;
        private int _age;
        private double _salary;
        public override int Id { get; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18)
                    _age = value;
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
            }
        }
        public Teacher(string name, string surname, int age, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        static Teacher()
        {
            _id = 0;
        }

        private Teacher()
        {
            _id++;
            Id = _id;
        }

        public static bool operator >(Teacher teacher1, Teacher teacher2)
        {
            return teacher1.Salary > teacher2.Salary;
        }
        public static bool operator <(Teacher teacher1, Teacher teacher2)
        {
            return teacher1.Salary < teacher2.Salary;
        }

        public override string ShowInfo()
        {
            return $"Id: {Id} Name: {Name} Age: {Age} Point: {Salary}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
