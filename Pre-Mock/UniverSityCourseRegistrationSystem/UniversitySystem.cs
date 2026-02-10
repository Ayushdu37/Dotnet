using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }
        public List<Student> ActiveStudents;

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
            ActiveStudents = new List<Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            if (AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException("Course code already exists");
            }
            Course course = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, course);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException("Student Id already exists");
            }
            Student student = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, student);
            ActiveStudents.Add(student);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            if (Students.ContainsKey(studentId) && AvailableCourses.ContainsKey(courseCode))
            {
                Student student = Students[studentId];
                Course course = AvailableCourses[courseCode];
                if (student.AddCourse(course))
                {
                    Console.WriteLine("Student successfully registered for the course");
                    return true;
                }
                else
                {
                    Console.WriteLine("Prerequisites not met.");
                    return false;
                }
            }
            return false;
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            if (Students.ContainsKey(studentId))
            {
                Student student = Students[studentId];
                // student.DropCourse(courseCode);
                return student.DropCourse(courseCode);
            }
            return false;
        }

        public void DisplayAllCourses()
        {
            if (AvailableCourses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            Console.WriteLine("Available Courses:");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Code\tName\t\tCredits\tEnrollment");
            Console.WriteLine("----------------------------------------------");

            foreach (Course course in AvailableCourses.Values)
            {
                Console.WriteLine(
                    $"{course.CourseCode}\t{course.CourseName}\t{course.Credits}\t{course.GetEnrollmentInfo()}"
                );
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Students[studentId].DisplaySchedule();
        }

        public void DisplaySystemSummary()
        {
            int totalStudents = Students.Count;
            int totalCourses = AvailableCourses.Count;

            int totalEnrollments = AvailableCourses.Values
                .Sum(c => int.Parse(c.GetEnrollmentInfo().Split('/')[0]));

            double averageEnrollment = totalCourses == 0
                ? 0
                : (double)totalEnrollments / totalCourses;

            Console.WriteLine("System Summary:");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Total Students : {totalStudents}");
            Console.WriteLine($"Total Courses  : {totalCourses}");
            Console.WriteLine($"Avg Enrollment: {averageEnrollment:F2}");
        }
    }
}
