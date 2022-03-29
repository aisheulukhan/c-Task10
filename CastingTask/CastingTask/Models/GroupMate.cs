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
      
    }
}