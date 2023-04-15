using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        //private IStudentRepository _studentRepository;

        //public StudentController(IStudentRepository studentRepository)
        //{
        //    _studentRepository = studentRepository;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    return View(await _studentRepository.GetAllAsync());
        //}


        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<IActionResult> Index(string key="")
        {
            return View(await _studentService.GetAllByKey(key));
        }
    }
}
