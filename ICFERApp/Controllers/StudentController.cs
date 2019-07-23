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
using NetBarcode;
using NToastNotify;
using ReflectionIT.Mvc.Paging;
using X.PagedList;

namespace ICFERApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IToastNotification _toastNotification;

        public StudentController(IStudentRepository studentRepository,IToastNotification toastNotification)
        {
            _studentRepository = studentRepository;
            _toastNotification = toastNotification;
        }

        // GET
        [Authorize]
        public  IActionResult Index(string search ,int? pageNumber)
        {
            
            var nextPage = pageNumber ?? 1;
            
            
            if (!string.IsNullOrEmpty(search))
            {
                var foundStudents = _studentRepository.SearchStudents(search);
                var onePageOfFoundStudents = foundStudents.ToPagedList(nextPage, 3);
                ViewBag.onePageOfStudents = onePageOfFoundStudents;
                return View();
                
            }
            var students =  _studentRepository.GetAllStudents();
            var onePageOfStudents = students.ToPagedList(nextPage, 3);
            ViewBag.onePageOfStudents = onePageOfStudents;
                        
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult New()
        {
            ViewBag.IsEditMode = "false";
            var student = new Student();
            return View(student);
        }


        [HttpPost]
        [Authorize]
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

                    if (file == null)
                    {
                       
                        _studentRepository.EditWithoutFile(student);
                        _toastNotification.AddSuccessToastMessage("Student has been edited successfully.");
                    }
                    else
                    {
                        _studentRepository.Edit(student);
                        UploadFile(file, student.Id);
                        _toastNotification.AddSuccessToastMessage("Student has been edited successfully.");
                        
                    }

                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                return RedirectToAction(nameof(Index));
            }

        }

        [Authorize]
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
        
        [Authorize]
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

        [Authorize]
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

        [Authorize]
        public IActionResult Details(long id)
        {
            var singleStudent = _studentRepository.GetSingleStudent(id);
            

//            ViewBag.BarcodeImage = value;
            return View(singleStudent);
        }


        
    }
}