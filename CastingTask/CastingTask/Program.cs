using System;

namespace CastingTask.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] students = new Student[0];
            Person[] teachers = new Teacher[0];
            GroupMate groupMate = new GroupMate();
            int key;


            do
            {
                Console.WriteLine("1. Telebe yarat");
                Console.WriteLine("2. Muellim yarat");
                Console.WriteLine("3. Ballarin muqayiyesi");
                Console.WriteLine("4. Maaslarin muqayiyesi");
                Console.WriteLine("Reqem daxil edin");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:

                    default:
                        break;
                }
            } while (key != 0);
        }
        static void InputName(string name)
        {
            Console.WriteLine("Ad daxil edin");
            name = Console.ReadLine();
        }
        static void InputSurname(string surname)
        {
            Console.WriteLine("Ad daxil edin");
            surname = Console.ReadLine();
        }
        public static void InputStudentPoint(double point)
        {
            do
            {
                Console.WriteLine("Bali daxil edin");
                point = Convert.ToInt32(Console.ReadLine());
                if (point > 100 || point < 0)
                {
                    Console.WriteLine("Yanlis daxil etdiniz!");

                }

            } while (point > 100 || point < 0);
        }
        public static void InpuTeachertSalary(double salary)
        {
            do
            {
                Console.WriteLine("Maasi daxil edin");
                salary = Convert.ToInt32(Console.ReadLine());
                if (salary < 0)
                {
                    Console.WriteLine("Yanlis daxil etdiniz!");

                }
            } while (salary <= 0);
        }
        public static void InputAgeStudent(int age)
        {
            do
            {
                Console.WriteLine("Yasi daxil edin");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 6 || age > 20)
                {
                    Console.WriteLine("Yanlis daxil edilib");
                }
            } while (age < 6 || age > 20);
        }
        public static void InputAgeTeacher(int age)
        {
            do
            {
                Console.WriteLine("Yasi daxil edin");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("Yanlis daxil edilib");
                }
            } while (age < 18);
        }


    }
}
