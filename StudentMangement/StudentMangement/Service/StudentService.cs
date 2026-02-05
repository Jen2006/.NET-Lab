using Microsoft.AspNetCore.Mvc;
using StudentMangement.Model;
namespace StudentMangement.Service

{
    public class StudentService : IStudentService
    {

        private readonly List<Student> _student = new();


        public List<Student> GetAll() => _student;

        public Student? GetById(int id) => _student.FirstOrDefault(s => s.Id == id);

        public Student Add(Student student)
        {
            student.Id = _student.Count + 1;
            _student.Add(student);
            return student;
        }


        public bool Delete(int id)
        {
            var student = GetById(id);
            if (student == null)
                return false;
            _student.Remove(student);
            return true;
        }

        public bool Update(int id, Student student)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Name = student.Name;
            existing.Age = student.Age;
            existing.Program = student.Program;
            return true;

        }


        //public bool Delete(int id, Student student)
        //{
        //    var students = GetById(id);
        //    if (students == null) return false;

        //    _student.Remove(students);
        //    return true;

        //}
    }
}