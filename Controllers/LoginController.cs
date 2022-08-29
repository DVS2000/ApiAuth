using ApiAuth.Models;
using ApiAuth.Repository;
using ApiAuth.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if(user is null) return NotFound(new { message = "Usuário ou senha inválido " });

            var token = TokenService.GerenateToken(user);

            return Ok(new { user, token });
        }
    }
}
