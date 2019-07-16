using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ICFERApp.Models;
using ICFERApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using ReflectionIT.Mvc.Paging;

namespace ICFERApp.Controllers
{
    public class StudentController : BaseController<Student>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IToastNotification _toastNotification;

        public StudentController(IStudentRepository studentRepository,IToastNotification toastNotification)
        {
            _studentRepository = studentRepository;
            _toastNotification = toastNotification;
        }

        // GET
        public  IActionResult Index(string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var foundStudents = _studentRepository.SearchStudents(search);
                return View(foundStudents);
            }
            var students =  _studentRepository.GetAllStudents();
                        
            return View(students);
        }

        [HttpGet]

        public IActionResult New()
        {
            ViewBag.IsEditMode = "false";
            var student = new Student();
            return View(student);
        }


        [HttpPost]
        public IActionResult New(Student student, string IsEditMode, IFormFile file)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.IsEditMode = IsEditMode;
                return View(student);
            }

            try
            {

                if (IsEditMode.Equals("false"))
                {

                    _studentRepository.Create(student);
                     UploadFile(file, student.Id);
                    _toastNotification.AddSuccessToastMessage("Student has been created successfully.");

                }

                else
                {
                    _studentRepository.Edit(student);
                     UploadFile(file, student.Id);
                    _toastNotification.AddSuccessToastMessage("Student has been edited successfully.");

                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                return RedirectToAction(nameof(Index));
            }

        }

        public IActionResult Edit(int id)
        {

            try
            {

                ViewBag.IsEditMode = "true";

                var student = _studentRepository.GetSingleStudent(id);

                return View("New", student);
            }
            catch (Exception ex)
            {
                return Content("Could not find Pet");
            }

        }

        public void UploadFile(IFormFile file, long studentId)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images",fileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            var student = _studentRepository.GetSingleStudent(studentId);
            student.ImageUrl = fileName;
            _studentRepository.Edit(student);
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var pet = _studentRepository.GetSingleStudent(id);
                _studentRepository.Delete(pet);
                _toastNotification.AddSuccessToastMessage("Student has been deleted successfully.");

                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {

                return BadRequest();
            }


        }

        public IActionResult Details(long id)
        {
            var pet = _studentRepository.GetSingleStudent(id);
            return View(pet);
        }
    }
}