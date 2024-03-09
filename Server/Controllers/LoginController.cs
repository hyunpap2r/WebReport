using BlazorApp1.Server.Interface;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IGlogin _glogin;

        public LoginController(IGlogin glogin)
        {
            _glogin = glogin;
        }

        [HttpGet]
        public ActionResult<EappUser> Get(string UserNo, string Password)
        {
            var user = _glogin.GetAllEappUsers().FirstOrDefault(u => u.UserNo == UserNo && u.Password == Password);
            
            if (user != null)
            {
                return user;
            }
            else
            {
                return NotFound(); // 일치하는 사용자가 없는 경우
            }
        }


    }

}
