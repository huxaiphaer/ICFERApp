using System.Collections.Generic;
using ICFERApp.Models;

namespace ICFERApp.Repository
{
    public interface IStudentRepository
    {
        void Create(Student student);
        void Edit(Student student);
        Student GetSingleStudent(int id);
        void Delete(Student student);
        List<Student> GetAllStudents();

    }
}