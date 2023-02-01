using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_9
{
    internal class Student
    {
        static int _count;
        public Student() 
        {
            _count++;
            Id = _count;

        }
        public int Id;
        public string FullName;
        public string GroupNo;
        public int Point;
    }
}
