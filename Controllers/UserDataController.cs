using Final.Models;
using Final.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Final.Controllers
{
    public class UserDataController : Controller
    {
      
        Context context = new Context();

        UserData UserData = new UserData();


        [HttpGet]
        [Authorize]
        public IActionResult PersonalInfo()
        {
         
           return View();
        }


        [HttpPost]
        [Authorize]
        public IActionResult CoverLetter(UserData userDataa)
        {
           

            UserData.PersonalInfo=userDataa.PersonalInfo;




            return View(UserData);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Skill(UserData userDataa)
        {
            UserData.CoverLetter = userDataa.CoverLetter;

           

            UserData.PersonalInfo = userDataa.PersonalInfo;


            return View(UserData);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Experience(UserData userDataa)
        {
           
            UserData.Skill = userDataa.Skill;
            UserData.CoverLetter=userDataa.CoverLetter;
            UserData.PersonalInfo = userDataa.PersonalInfo;

            return View(UserData);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Project(UserData userDataa)
        {
            UserData.Experiences = userDataa.Experiences;

            UserData.Skill = userDataa.Skill;
            UserData.CoverLetter = userDataa.CoverLetter;
            UserData.PersonalInfo = userDataa.PersonalInfo;

            return View(UserData);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Link(UserData userDataa)
        {
            UserData.Projects= userDataa.Projects;

            UserData.Experiences = userDataa.Experiences;

            UserData.Skill = userDataa.Skill;
            UserData.CoverLetter = userDataa.CoverLetter;
            UserData.PersonalInfo = userDataa.PersonalInfo;
            return View(UserData);
        }
        [HttpPost, Authorize]
        public IActionResult createCv(UserData userDataa)
        {
            UserData.Links = userDataa.Links;

            UserData.Projects = userDataa.Projects;

            UserData.Experiences = userDataa.Experiences;

            UserData.Skill = userDataa.Skill;
            UserData.CoverLetter = userDataa.CoverLetter;
            UserData.PersonalInfo = userDataa.PersonalInfo;



            context.UserData.Add(UserData);
            context.SaveChanges();

            return View("SliderLayout");
        }
    }
}
