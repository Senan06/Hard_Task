using System;
using System.Collections.Generic;
using System.Text;

namespace HardTask.Models
{
    class Group
    {
        private static int _no=100;
        public string No 
        {
            get
            {
                return $"AP{_no}";
            }        
        }
        public Student[] students;
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;            
        }
        public string GetAllStudents(Student[] studentsArr)
        {
            foreach (Student item in studentsArr)
            {
                return item.Showinfo();
            }
            return "";
        }
        public Student[] Sort()
        {
            Student[] inputStudents = new Student[students.Length];
            Student 
            for(int i=0 ; i<inputStudents.Length; i++)
            {
                for (int j = i; j < students.Length; j++)
                {
                    
                }
            }
            return inputStudents;
        }
    }
}
