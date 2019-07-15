using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ICFERApp.Data;
using ICFERApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ICFERApp.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Edit(Student student)
        {
            var existingStudent = _context.Students
                .Include(e => e.Education)
                .Include(s => s.Siblings)
                .Include(p => p.Parents)
                .Include(g => g.Guardian)
                .FirstOrDefault(s => s.Id == student.Id);

            if (existingStudent != null)
            {
                // do some updating.
                
                _context.Entry(existingStudent).CurrentValues.SetValues(student);
                _context.Entry(existingStudent).State = EntityState.Modified;
               
                
               // updating the parent.
               //first get the particular parent by with respect to the student.
                var parent = _context.Parents.
                    FirstOrDefault(s => s.StudentId == existingStudent.Id);
                
                System.Console.WriteLine("parent ***** "+ parent.Id);
                _context.Entry(parent).CurrentValues.SetValues(student.Parents);
                _context.Entry(parent).State = EntityState.Modified;
                System.Console.WriteLine("updated ***** "+ parent.NamesOfFather);

                
                //updating education.
                var education = _context.Education.FirstOrDefault(e => e.StudentId == existingStudent.Id);
                _context.Entry(education).CurrentValues.SetValues(student.Education);
                _context.Entry(education).State = EntityState.Modified;

                //updating guardian.
                var guardian = _context.Guardian.FirstOrDefault(g => g.StudentId == existingStudent.Id);
                _context.Entry(guardian).CurrentValues.SetValues(student.Guardian);
                _context.Entry(guardian).State = EntityState.Modified;
                
                //updating sibling.
                
                var sibling = _context.Siblings.FirstOrDefault(s => s.StudentId == existingStudent.Id);
                System.Console.WriteLine("**  " + existingStudent.Id + " sibling - "+ sibling.NumberOfBrothers);
                _context.Entry(sibling).CurrentValues.SetValues(student.Siblings);
                _context.Entry(sibling).State = EntityState.Modified;
                System.Console.WriteLine("******** sibling - "+ sibling.NumberOfBrothers);
                
               
                
            }
            _context.SaveChanges();
            
            
        }

        public Student GetSingleStudent(int id)
        {

            var student = _context.Students
                .Include(e => e.Education)
                .Include(s => s.Siblings)
                .Include(p => p.Parents)
                .Include(g => g.Guardian)
                .FirstOrDefault(s => s.Id == id);
            return student;
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }


        public List<Student> GetAllStudents()
        {
            return _context.Students.
                ToList();
        }
    }
}