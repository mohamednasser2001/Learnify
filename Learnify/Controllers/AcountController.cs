using Learnify.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Learnify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AcountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser>signInManager,
            RoleManager<IdentityRole> roleManager
            ) {

            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Regester(ApplicationUserDTO userDTO)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = new ApplicationUser()
                {
                    UserName = userDTO.Name,
                    Email = userDTO.Email,
                    City = userDTO.City,
                };

                var resualt = await userManager.CreateAsync(applicationUser, userDTO.Password);
                if (resualt.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("Password", "InvalidPassword");
            }
            return BadRequest(userDTO);
        }
    }
}
