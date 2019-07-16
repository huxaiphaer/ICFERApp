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
                       
               // updating parents.
               existingStudent.Parents.ReligionOfDeceasedFather = student.Parents.ReligionOfDeceasedFather;
               existingStudent.Parents.ReligionOfDeceasedMother = student.Parents.ReligionOfDeceasedMother;
               existingStudent.Parents.DateOfDemiseOfFather = student.Parents.DateOfDemiseOfFather;
               existingStudent.Parents.DateOfDemiseOfMother = student.Parents.DateOfDemiseOfMother;
               existingStudent.Parents.NamesOfMother = student.Parents.NamesOfMother;
               existingStudent.Parents.NamesOfFather = student.Parents.NamesOfFather;
               existingStudent.Parents.ReligionOfMother = student.Parents.ReligionOfMother;
               existingStudent.Parents.MaritalStatusOfMother = student.Parents.MaritalStatusOfMother;
               existingStudent.Parents.OccupationOfMother = student.Parents.OccupationOfMother;
               existingStudent.Parents.MonthlyIncome = student.Parents.MonthlyIncome;
               

               // updating guardian.

               existingStudent.Guardian.FirstName = student.Guardian.FirstName;
               existingStudent.Guardian.MiddleName = student.Guardian.MiddleName;
               existingStudent.Guardian.LastName = student.Guardian.LastName;
               existingStudent.Guardian.Comments = student.Guardian.Comments;
               existingStudent.Guardian.Occupation = student.Guardian.Occupation;
               existingStudent.Guardian.RelationshipToOrphan = student.Guardian.RelationshipToOrphan;
               existingStudent.Guardian.MonthlyIncome = student.Guardian.MonthlyIncome;
               existingStudent.Guardian.EmployersName = student.Guardian.EmployersName;
               existingStudent.Guardian.WorkAddress = student.Guardian.WorkAddress;
               existingStudent.Guardian.MobileNo = student.Guardian.MobileNo;
               existingStudent.Guardian.PhysicalLocation = student.Guardian.PhysicalLocation;
               

                //updating education.
                
                existingStudent.Education.School = student.Education.School;
                existingStudent.Education.Telephone = student.Education.Telephone;
                existingStudent.Education.HeadTeacher = student.Education.HeadTeacher;
                existingStudent.Education.EducationLevel = student.Education.EducationLevel;
                existingStudent.Education.AddressOfSchool = student.Education.AddressOfSchool;
                
                //updating sibling.
                
                existingStudent.Siblings.NumberOfBrothers = student.Siblings.NumberOfBrothers;
                existingStudent.Siblings.NumberOfSisters = student.Siblings.NumberOfSisters;
       
               
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