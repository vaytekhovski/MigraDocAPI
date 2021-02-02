using Microsoft.AspNetCore.Mvc;
using Com.SNGJob.Core.Exceptions;
using MigraDoc.Core.CRUD;
using Microsoft.Extensions.Logging;
using System;
using MigraDoc.Core.Models.FullData;
using System.Threading.Tasks;

namespace MigraDoc.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ILogger<UserController> logger;

        private UserDataRepository UserDataRepository { get; set; }
        public UserController(UserDataRepository userDataRepository, ILogger<UserController> _logger)
        {
            UserDataRepository = userDataRepository;
            logger = _logger;
        }

        [HttpPost("{tgUserId}/start")]
        public async Task<IActionResult> init(string tgUserId)
        {
            try
            {
                var user = await UserDataRepository.CreateUser(tgUserId);

                return Ok(user);
            }
            catch(UserCreateFailedException e)
            {
                return BadRequest("Пользователь уже существует");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> update([FromBody] UserDetail user)
        {
            var userDetail = await UserDataRepository.UpdateUserDetail(user);
            return Ok(userDetail);
        }

        [HttpGet("{tgUserId}/data")]
        public async Task<IActionResult> getUserData(string tgUserId)
        {
            try
            {
                var userDetail = await UserDataRepository.GetUserDetail(tgUserId);
                return Ok();
            }
            catch(UserNotFoundException e)
            {
                return BadRequest("Пользователь не найден");
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



       
    }
}