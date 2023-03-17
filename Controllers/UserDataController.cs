using Final.Models;
using Final.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace Final.Controllers
{
    public class UserDataController : Controller
    {
        Context context = new Context();


        [HttpGet]
        [Authorize]
        public IActionResult PersonalInfo()
        {

            return View();
        }


        //[HttpGet]
        //[Authorize]
        //public IActionResult CoverLetter()
        //{

        //    return View();
        //}
        [HttpPost]
        [Authorize]
        public IActionResult CoverLetter(PersonalInfo personalInfo)
        {
            CoverLetterViewModel coverLetter = new CoverLetterViewModel();

            coverLetter.Name = personalInfo.Name;
            coverLetter.Address = personalInfo.Address;
            coverLetter.Phone = personalInfo.Phone;
            coverLetter.Photo = personalInfo.Photo;
            coverLetter.Email = personalInfo.Email;
            coverLetter.JobTitle = personalInfo.JobTitle;


            return View(coverLetter);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Skill(CoverLetterViewModel coverrLetter)
        {
            SkillViewModel skill = new SkillViewModel();

            skill.Email = coverrLetter.Email;
            skill.Name = coverrLetter.Name;
            skill.Address = coverrLetter.Address;
            skill.Phone = coverrLetter.Phone;
            skill.Photo = coverrLetter.Photo;
            skill.JobTitle = coverrLetter.JobTitle;
            skill.CoverLetter = coverrLetter.CoverLetter;


            return View(skill);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Experience(SkillViewModel Userskill)
        {
            ExperienceViewModel experience = new ExperienceViewModel();

            experience.Email = Userskill.Email;
            experience.Name = Userskill.Name;
            experience.Address = Userskill.Address;
            experience.Phone = Userskill.Phone;
            experience.Photo = Userskill.Photo;
            experience.JobTitle = Userskill.JobTitle;
            experience.CoverLetter = Userskill.CoverLetter;
            experience.Level = Userskill.Level;
            experience.SkillName = Userskill.SkillName;

            return View(experience);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Project(ExperienceViewModel UserExperience)
        {
            ProjectViewModel project = new ProjectViewModel();

            project.Email = UserExperience.Email;
            project.Name = UserExperience.Name;
            project.Address = UserExperience.Address;
            project.Phone = UserExperience.Phone;
            project.Photo = UserExperience.Photo;
            project.JobTitle = UserExperience.JobTitle;
            project.CoverLetter = UserExperience.CoverLetter;
            project.Level = UserExperience.Level;
            project.SkillName = UserExperience.SkillName;
            project.ExperienceJobTitle = UserExperience.ExperienceJobTitle;
            project.CompanyName = UserExperience.CompanyName;
            project.StartDate = UserExperience.StartDate;
            project.EndDate = UserExperience.EndDate;
            project.Details = UserExperience.Details;

            return View(project);
        }


        [HttpPost]
        [Authorize]
        public IActionResult Link(ProjectViewModel Userproject)
        {
            LinkViewModel link = new LinkViewModel();

            link.ProjectLink = Userproject.Link;
            link.Title = Userproject.Title;
            link.Description = Userproject.Description;
            link.Address = Userproject.Address;
            link.Phone = Userproject.Phone;
            link.Photo = Userproject.Photo;
            link.JobTitle = Userproject.JobTitle;
            link.CoverLetter = Userproject.CoverLetter;
            link.Level = Userproject.Level;
            link.SkillName = Userproject.SkillName;
            link.Email = Userproject.Email;
            link.CompanyName = Userproject.CompanyName;
            link.StartDate = Userproject.StartDate;
            link.EndDate = Userproject.EndDate;
            link.Details = Userproject.Details;
            link.ExperienceJobTitle = Userproject.ExperienceJobTitle;

            return View(link);
        }
        [HttpPost, Authorize]
        public IActionResult createCv(LinkViewModel Userlink)
        {
            UserData userData = new UserData();

            userData.CoverLetter = Userlink.CoverLetter;
            userData.PersonalInfo = Userlink.PersonalInfos;
            userData.Links = Userlink.links;
            userData.Skill = Userlink.skills;
            userData.Experiences = Userlink.experiences;
            userData.Projects = Userlink.projects;


            context.UserData.Add(userData);
            context.SaveChanges();

            return View();
        }
    }
}
