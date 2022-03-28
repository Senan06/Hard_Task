using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Point { get; set; }
        public string Showinfo()
        {
            return $" ";
        }
        public static bool operator >(Student student, Student student2)
        {
            return student.Point > student2.Point;
        }
        public static bool operator <(Student student, Student student2)
        {
            return student.Point < student2.Point;
        }

    }
}
