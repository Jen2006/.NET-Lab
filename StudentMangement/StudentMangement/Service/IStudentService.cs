using StudentMangement.Model;

namespace StudentMangement.Service
{
    public interface IStudentService
    {
        Student Add(Student student);
        bool Delete(int id);
       
        List<Student> GetAll();
        Student? GetById(int id);
        bool Update(int id, Student student);
    }
}