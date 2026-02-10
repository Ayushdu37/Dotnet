using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Course Class
    // =========================
    public class Course
    {
        public string CourseCode { get; private set; }
        public string CourseName { get; private set; }
        public int Credits { get; private set; }
        public int MaxCapacity { get; private set; }
        public List<string> Prerequisites { get; private set; }

        private int CurrentEnrollment;

        public Course(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            CourseCode = code;
            CourseName = name;
            Credits = credits;
            MaxCapacity = maxCapacity;
            Prerequisites = prerequisites ?? new List<string>();
            CurrentEnrollment = 0;
        }

        public bool IsFull()
        {
            return CurrentEnrollment >= MaxCapacity ? true : false;
        }

        public bool HasPrerequisites(List<string> completedCourses)
        {
            // throw new NotImplementedException();
            if(Prerequisites.Count == 0) return true;
            foreach(string prerequisite in Prerequisites)
            {
                if(!completedCourses.Contains(prerequisite)) return false;
            }
            return true;
        }

        public void EnrollStudent()
        {
            if (IsFull())
            {
                throw new InvalidOperationException();
            }
            else
            {
                CurrentEnrollment++;
            }
        }

        public void DropStudent()
        {
            if(CurrentEnrollment > 0)
            {
                CurrentEnrollment--;
            }
        }

        public string GetEnrollmentInfo()
        {
            return $"{CurrentEnrollment}/{MaxCapacity}";
        }
    }
}
