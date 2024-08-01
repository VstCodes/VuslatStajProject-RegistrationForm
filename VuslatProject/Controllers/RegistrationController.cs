using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VuslatProject.Models.RegistrationInfo;

namespace VuslatProject.Controllers
{
    public class RegistrationController : Controller
    {


        private readonly RepositoryContext _context;

        public RegistrationController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: /RegistrationForm/Index
        public async Task<IActionResult> Index()
        {
            List<Department> departments = await _context.Departments.ToListAsync();
            ViewBag.Departments = departments;

            List<Employee> employees = await _context.Employees.ToListAsync();
            ViewBag.Employees = employees;

            return View();
        }

        // POST: /RegistrationForm/Create
        [HttpPost]
        public async Task<IActionResult> Create(Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            // Verileri yeniden yükleyerek formu tekrar göster
            ViewBag.Departments = await _context.Departments.ToListAsync();
            ViewBag.Employees = await _context.Employees.ToListAsync();
            return View("Index", visitor);
        }


    }
}
