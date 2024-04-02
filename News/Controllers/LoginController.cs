using Contracts;
using Entities.DTOs.Users;
using Entities.Model.Users;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers
{
    [Route("api")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public LoginController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager ?? throw new ArgumentNullException(nameof(repositoryManager));
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginAsync([FromBody] UserCredentials userCredentials , CancellationToken cancellationToken)
        {
            if(userCredentials == null)
            {
                return BadRequest("Ma'lumotlar to'ldirilmagan holda kiritildi");
            }

            var user = await _repositoryManager.Login.
                LoginAsync(userCredentials.UserName, _repositoryManager.Login.HashPassword(userCredentials.Password), false, cancellationToken);

            if(user == null || !user.IsActive)
            {
                return NoContent();
            }

            return Ok(user);
        }
    }
}