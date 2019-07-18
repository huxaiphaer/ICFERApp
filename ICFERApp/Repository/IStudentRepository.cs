using System.Collections.Generic;
using System.Threading.Tasks;
using ICFERApp.Models;
using ReflectionIT.Mvc.Paging;

namespace ICFERApp.Repository
{
    public interface IStudentRepository
    {
        void Create(Student student);
        void Edit(Student student);
        void EditWithoutFile(Student student);
        Student GetSingleStudent(long id);
        void Delete(Student student);
        List<Student> GetAllStudents();
        Task<PagingList<Student>> GetOrderedList(int page = 1);

        List<Student> SearchStudents(string search);
    }
}