using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10_pr_dop
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }

    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, string fullName, int[] grades)
        {
            Name = name;
            FullName = fullName;
            Grades = grades;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public double GetAvgGrade()
        {
            if (Grades.Length == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] studentGrades = { 85, 90, 78, 95, 88 };
            IStudent student = new Student("Дильша", "Мусин Дильшат", studentGrades);

            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Full Name: {student.FullName}");
            Console.WriteLine($"Grades: [{string.Join(", ", student.Grades)}]");
            Console.WriteLine($"Average Grade: {student.GetAvgGrade()}");
        }
    }
}
