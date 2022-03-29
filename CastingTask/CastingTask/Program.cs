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
            int index = 0;
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
                        string Sname = "";
                        string Ssurname = "";
                        int Sage = 0;
                        double point = 0;
                        InputStudentName(Sname);
                        InputStudentSurname(Ssurname);
                        InputAgeStudent(Sage);
                        InputStudentPoint(point);
                        Student student = new Student(Sname, Ssurname, Sage, point);
                        
                        break;
                    case 2:
                        string Tname = "";
                        string Tsurname = "";
                        int Tage = 0;
                        double salary = 0;
                        InputTeacherName(Tname);
                        InputTeacherSurname(Tsurname);
                        InputAgeTeacher(Tage);
                        InpuTeachertSalary(salary);
                        Teacher teacher = new Teacher(Tname, Tsurname, Tage, salary);
                        
                        break;
                    default:
                        break;
                }
            } while (key != 4);
        }
        static void InputStudentName(string name)
        {
            Console.WriteLine("Ad daxil edin");
            name = Console.ReadLine();
        }
        static void InputStudentSurname(string surname)
        {
            Console.WriteLine("Soyad daxil edin");
            surname = Console.ReadLine();
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
        static void InputTeacherName(string name)
        {
            Console.WriteLine("Ad daxil edin");
            name = Console.ReadLine();
        }
        static void InputTeacherSurname(string surname)
        {
            Console.WriteLine("Ad daxil edin");
            surname = Console.ReadLine();
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
        
      


    }
}
