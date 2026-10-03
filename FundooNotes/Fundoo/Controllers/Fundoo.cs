using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;
namespace Fundoo.Controllers
{
    [ApiController] //mera frontend se data is class m ayega// annotation btati h ye controler class h
    [Route("api/[controller]")] //Automatically consider address as WeatherForecast (anything before controller word)
    public class FundooController : ControllerBase
    {
        private IUserBl _userBl;
        private readonly JwtService _jwtService;
        public FundooController(IUserBl userBl, JwtService jwtService)
        {
            _userBl = userBl;
            _jwtService = jwtService;
        }
        [Authorize]
        [HttpGet("protected")]
        public IActionResult Protected()
        {
            return Ok("You are authorized!");
        }
        [HttpPost]
        public RegistrationModel RegisterUser(RegistrationModel registrationModel)
        {
            return _userBl.RegisterUserBL(registrationModel);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel loginModel)
        {
            var result = _userBl.LoginUserBL(loginModel);

            if (result == null)
            {
                return Unauthorized("Invalid email or password");
            }

            string token = _jwtService.GenerateToken(result.email);

            return Ok(new
            {
                message = "Login successful",
               token = token
            });
        }
    }
}
