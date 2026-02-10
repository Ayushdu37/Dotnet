using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            int sum = 0;
            foreach(Course course in RegisteredCourses)
            {
                sum += course.Credits;
            }
            return sum;
        }

        public bool CanAddCourse(Course course)
        {
            return GetTotalCredits() + course.Credits <= MaxCredits;
        }

        public bool AddCourse(Course course)
        {
            if (CanAddCourse(course) && (!course.IsFull()))
            {
                RegisteredCourses.Add(course);
                course.EnrollStudent();
                return true;
            }
            return false;
        }

        public bool DropCourse(string courseCode)
        {
            foreach (Course course in RegisteredCourses)
            {
                if (course.CourseCode == courseCode)
                {
                    RegisteredCourses.Remove(course);
                    return true;
                }
            }
            return false;
        }

        public void DisplaySchedule()
        {
            if (RegisteredCourses.Count == 0)
            {
                Console.WriteLine("No courses registered.");
                return;
            }

            Console.WriteLine("Registered Courses:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Code\tName\t\tCredits");
            Console.WriteLine("--------------------------------");

            foreach (Course course in RegisteredCourses)
            {
                Console.WriteLine($"{course.CourseCode}\t{course.CourseName}\t{course.Credits}");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total Credits: {GetTotalCredits()}");
        }
    }
}
