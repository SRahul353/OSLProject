using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSLProject.Data;
using OSLProject.Models;
using System;
using System.Threading.Tasks;

namespace OSLProject.Controllers
{
    public class ReplyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReplyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int questionId, string replyContent)
        {

                var question = await _context.QAModels.FindAsync(questionId);
                if (question != null)
                {
                    var user = User.Identity.Name; 
                    var reply = new ReplyModel
                    {
                        Content = replyContent,
                        CreatedAt = DateTime.Now,
                        User = user,
                        QAModelId = questionId
                    };

                    _context.ReplyModels.Add(reply);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "QA"); 
                }
                else
                {
                    return NotFound(); 
                }
            
            return RedirectToAction("Index", "Home"); 
        }
    }
}