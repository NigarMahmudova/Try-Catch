using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_9
{
    internal class Course
    {
        public int StudentsLimit;
        public Student[] Students = new Student[0];
        public void AddStudent(Student student)
        {
            if (Students.Length < StudentsLimit)
            {
                if (true)
                {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = student;
                }
            }
        }

        public bool HasStudent(int no)
        {
            foreach (var item in Students)
            {
                if (item.Id == no)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
