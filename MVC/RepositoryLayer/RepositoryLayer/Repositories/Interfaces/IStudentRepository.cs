using RepositoryLayer.Models;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
    }
}
