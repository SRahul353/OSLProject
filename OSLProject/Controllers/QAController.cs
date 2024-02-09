using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using OSLProject.Data;
using OSLProject.Models;

namespace OSLProject.Controllers
{
    [Authorize]
    public class QAController : Controller
    {
        

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public QAController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> IndexAsync()
        {

            var posts = await _context.QAModels.Include(q => q.Replies).ToListAsync();

            return View(posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QAModel QA)
        {

                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    QA.User = user.UserName;
                    QA.CreatedAt = DateTime.Now;
                    _context.QAModels.Add(QA);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "QA");
                }
                else
                {
                    return RedirectToAction("Login", "Account");
                }
            
            return View(QA);
        }
    }
}
