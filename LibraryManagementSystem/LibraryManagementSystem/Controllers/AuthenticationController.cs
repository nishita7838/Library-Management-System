using LibraryManagementSystem.Data;
using LibraryManagementSystem.DTOs;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly LMSDBContext context;


        public AuthenticationController(LMSDBContext _context) 
        {
            this.context = _context;
        }
        [HttpPost("RegisterUser")]
        public async Task<IActionResult> registerUser(Users users)
        {
            if(context.Users.Where(u=>u.Email==users.Email).FirstOrDefault()!=null)
            {
                return Ok("User already exists");
            }
            else {
                await context.Users.AddAsync(users);
                context.SaveChanges();
                return Ok("Success");
            }
            
        }
        [HttpPost("Login")]
        public async Task<IActionResult> login(Users users)
        {
            var loggedInUser = context.Users.Where(u => u.Email == users.Email&&u.Password==users.Password).FirstOrDefault();
            
                await context.Users.AddAsync(users);
                context.SaveChanges();
                return Ok("Success");
            

        }

    }
}
