using Final.Models;
using Final.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;

namespace Final.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController
            (UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            this.userManager = _userManager;
            this.signInManager = _signInManager;
        }
        Context context = new Context();
        public IActionResult Registration()
        {

            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegisterationViewModel newUserVM)
        
        {
            if (ModelState.IsValid)
            {
               
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUserVM.UserNAme;
                userModel.PasswordHash = newUserVM.Password;
                userModel.Email = newUserVM.Email;

                IdentityResult result =
                    await userManager.CreateAsync(userModel, newUserVM.Password);

                if (result.Succeeded)
                {
                    
                    List<Claim> addClaim = new List<Claim>();
                   
                    await signInManager.SignInWithClaimsAsync(userModel, false, addClaim);
                    
                    return RedirectToAction("", "");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(newUserVM);
        }

        public async Task<IActionResult> signOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel userVmReq)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userModel =
                    await userManager.FindByNameAsync(userVmReq.UserName);
                if (userModel != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult rr =
                        await signInManager.PasswordSignInAsync(userModel, userVmReq.Password, userVmReq.RememberMe, false);
                    if (rr.Succeeded)

                        //hayro7 el main page bta3tna
                        return RedirectToAction("", "");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username or Password");
                }
            }
            return View(userVmReq);
        }
        public IActionResult main()
        {
            
            return View();
        }
    }
}
