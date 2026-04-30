using StudentCourseManagement.Models;

namespace StudentCourseManagement.repo;

public interface IStudentRepository
{
    IEnumerable<Student> GetAll();
    Student GetById(int id);
    void Add(Student student);
    void Update(Student student);
    void Delete(int id);
}