using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": // Add Course
                            Console.Write("Course Code: ");
                            string code = Console.ReadLine();

                            Console.Write("Course Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Credits (1-4): ");
                            if (!int.TryParse(Console.ReadLine(), out int credits) || credits < 1 || credits > 4)
                            {
                                Console.WriteLine("Invalid credits.");
                                break;
                            }

                            Console.Write("Max Capacity (10-100): ");
                            if (!int.TryParse(Console.ReadLine(), out int capacity) || capacity < 10 || capacity > 100)
                            {
                                Console.WriteLine("Invalid capacity.");
                                break;
                            }

                            Console.Write("Prerequisites (comma-separated, or empty): ");
                            string prereqInput = Console.ReadLine();
                            List<string> prereqs = string.IsNullOrWhiteSpace(prereqInput)
                                ? new List<string>()
                                : prereqInput.Split(',').Select(p => p.Trim()).ToList();

                            system.AddCourse(code, name, credits, capacity, prereqs);
                            Console.WriteLine("Course added successfully.");
                            break;

                        case "2": // Add Student
                            Console.Write("Student ID: ");
                            string studentId = Console.ReadLine();

                            Console.Write("Student Name: ");
                            string studentName = Console.ReadLine();

                            Console.Write("Major: ");
                            string major = Console.ReadLine();

                            Console.Write("Max Credits (<=24): ");
                            if (!int.TryParse(Console.ReadLine(), out int maxCredits) || maxCredits > 24)
                            {
                                Console.WriteLine("Invalid max credits.");
                                break;
                            }

                            Console.Write("Completed Courses (comma-separated, or empty): ");
                            string completedInput = Console.ReadLine();
                            List<string> completedCourses = string.IsNullOrWhiteSpace(completedInput)
                                ? new List<string>()
                                : completedInput.Split(',').Select(c => c.Trim()).ToList();

                            system.AddStudent(studentId, studentName, major, maxCredits, completedCourses);
                            Console.WriteLine("Student added successfully.");
                            break;

                        case "3": // Register Student for Course
                            Console.Write("Student ID: ");
                            string regStudentId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string regCourseCode = Console.ReadLine();

                            system.RegisterStudentForCourse(regStudentId, regCourseCode);
                            break;

                        case "4": // Drop Student from Course
                            Console.Write("Student ID: ");
                            string dropStudentId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string dropCourseCode = Console.ReadLine();

                            if (system.DropStudentFromCourse(dropStudentId, dropCourseCode))
                                Console.WriteLine("Course dropped successfully.");
                            else
                                Console.WriteLine("Unable to drop course.");
                            break;

                        case "5": // Display All Courses
                            system.DisplayAllCourses();
                            break;

                        case "6": // Display Student Schedule
                            Console.Write("Student ID: ");
                            string scheduleStudentId = Console.ReadLine();
                            system.DisplayStudentSchedule(scheduleStudentId);
                            break;

                        case "7": // Display System Summary
                            system.DisplaySystemSummary();
                            break;

                        case "8": // Exit
                            exit = true;
                            Console.WriteLine("Exiting system. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

