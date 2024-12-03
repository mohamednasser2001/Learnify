using AutoMapper;
using Learnify.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models;

namespace Learnify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager,IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

       [HttpPost("Regester")]
    public async Task<IActionResult> Regester(ApplicationUserDTO userDTO)
    {
        if (roleManager.Roles.IsNullOrEmpty())
        {
            await roleManager.CreateAsync(new("Admin"));
            await roleManager.CreateAsync(new("Instructor"));
            await roleManager.CreateAsync(new("Student"));
        }

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
                await userManager.AddToRoleAsync(applicationUser, "Student");
                await signInManager.SignInAsync(applicationUser,false);
            }
            ModelState.AddModelError("Password", "InvalidPassword");
        }
        return BadRequest(userDTO);
    }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(loginDTO.Name);
                if (user != null)
                {
                    var result = await userManager.CheckPasswordAsync(user, loginDTO.Password);

                    if (result)
                    {
                        await signInManager.SignInAsync(user, false);
                        return Ok(user);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "There are errors");
                    }
                }
                return NotFound();
            }
            return BadRequest(loginDTO);
        }

        [HttpDelete("Logout")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Ok();
        }
    }
}
