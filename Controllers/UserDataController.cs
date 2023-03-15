using Final.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace Final.Controllers
{
    public class UserDataController : Controller
    {
        Context context= new Context();
        [HttpGet]
        [Authorize]
        public IActionResult PersonalInfo()
        {

            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult CoverLetter()
        {

            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult Skill()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Skill(Skill Newskill,string submit)
        {
            //if (submit == "Add")
            //{
            //    context.Skills.Add(Newskill);
            //    context.SaveChanges();
            //    ModelState.Clear();
            //    return View();
            //}
            //else if (submit == "Next")
            //{
            //    return RedirectToAction("Experience");
            //}

            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult Experience()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult Project()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult Link()
        {
            return View();
        }
    }
}
