using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {

        private readonly IStudentRepsitory _studentRepsitory;
        
        public HomeController(IStudentRepsitory studentRepsitory)
        {
            _studentRepsitory = studentRepsitory;

        }
        public IActionResult Index()
        {
            IEnumerable<Student> students = _studentRepsitory.GetAllStudents();
            return View(students);
        }
        public IActionResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepsitory.GetStudent(id??1),
                PageTitle = "Student Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}