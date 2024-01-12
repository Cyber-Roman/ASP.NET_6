using AspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AspNetMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationContext db;

        public UsersController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = await db.Users.ToListAsync();
            foreach (var user in users)
            {
                Console.WriteLine($"Iм'я: {user.FirstName}, Прiзвище: {user.LastName}, Вiк: {user.Age}");
            }
            return View("./Views/Users/Index.cshtml", await db.Users.ToListAsync());
        }

        public async Task<IActionResult> ViewCompany()
        {
            return View("./Views/Users/Company.cshtml", await db.Companies.ToListAsync());
        }

        public IActionResult Create()
        {
            return View("./Views/Users/CreateUser.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName, Age")] UserModel user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
