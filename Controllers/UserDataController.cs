using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace Final.Controllers
{
    public class UserDataController : Controller
    {
        Context context= new Context();
        [HttpGet]
        public IActionResult PersonalInfo()
        {

            return View();
        }
        [HttpGet]
        public IActionResult CoverLetter()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Skill()
        {
            return View();
        }

        [HttpPost]
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
        public IActionResult Experience()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Project()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Link()
        {
            return View();
        }
    }
}
