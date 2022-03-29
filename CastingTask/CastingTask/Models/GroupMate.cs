using System;
using System.Collections.Generic;
using System.Text;

namespace CastingTask.Models
{
    class GroupMate
    {
        private Student[] students = new Student[0];

        public Student this[int index]
        {
            get { return students[index]; }
            set
            {
                Array.Resize(ref students, students.Length + 1);
                students[index] = value;
            }
        }
        public void Sort()
        {
            if (students.Length > 1)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    for (int j = i; j < students.Length; j++)
                    {
                        if (students[j] > students[i])
                        {
                            students[i].Point = students[i].Point + students[j].Point;
                            students[j].Point = students[i].Point - students[j].Point;
                            students[i].Point = students[i].Point - students[j].Point;
                        }
                        else
                        {
                            Console.WriteLine("Min > 2");
                        }
                    }

                }
            }
        }
        public void SortPoint()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
