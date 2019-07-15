using System;
using System.Diagnostics;
using ICFERApp.Models;
using ICFERApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

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
        public IActionResult Index()
        {

            var students = _studentRepository.GetAllStudents();
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
        public IActionResult New(Student student, string IsEditMode)
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
                    _toastNotification.AddSuccessToastMessage("Student has been created successfully.");

                }

                else
                {
                    _studentRepository.Edit(student);
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

        public IActionResult Details(int id)
        {
            var pet = _studentRepository.GetSingleStudent(id);
            return View(pet);
        }
    }
}