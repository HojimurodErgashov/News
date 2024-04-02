using AutoMapper;
using Contracts;
using Entities.DTOs.Users;
using Entities.Model.Users;
using Microsoft.AspNetCore.Mvc;

namespace News.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repositoryManager;

        public UserController(IRepositoryManager repositoryManager , IMapper mapper)
        {
            _repositoryManager = repositoryManager ?? throw new ArgumentNullException(nameof(repositoryManager));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("/getAll")]
        public async Task<ActionResult<List<UserDTO>>> GetAllAsync()
        {
            List<User> users = await _repositoryManager.User.GetAllAsync();
            if(users.Count == 0)
            {
                return NoContent();
            }

            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (var user in users)
            {
                userDTOs.Add(_mapper.Map<UserDTO>(user));
            }

            return Ok(userDTOs);
        }

        [HttpPost("/create")]
        public async  Task<ActionResult<UserDTO>> CreateAsync([FromBody] UserCreatedDTO userCreatedDTO)
        {
            User user;
            UserDTO userDTO;
            if(userCreatedDTO == null)
            {
                return BadRequest();
            }

            user = _mapper.Map<User>(userCreatedDTO);
            user.Password = _repositoryManager.Login.HashPassword(user.Password);

            try
            {
                await _repositoryManager.User.CreateAsync(user);
                await _repositoryManager.SaveAsync();
                await _repositoryManager.EmailService.SendEmailAsync(email: user.Email , subject: "Siz bu link orqali bizning saytga yo'naltirilasiz",message: "Siz bu link orqali kirib o'zingizning avval kiritgan password va username larni qayta kiritib active lasha olasiz!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
               
            userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);
        }
    }
}
