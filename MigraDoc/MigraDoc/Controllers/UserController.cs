using Microsoft.AspNetCore.Mvc;
using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using MigraDoc.Core.Converters;
using Com.SNGJob.Core.Exceptions;
using MigraDoc.Core.CRUD;
using Microsoft.Extensions.Logging;
using System;
using Newtonsoft.Json;

namespace MigraDoc.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ILogger<UserController> logger;

        private UserDataConverter UserDataConverter = new UserDataConverter();

        private UserConverter UserConverter = new UserConverter();
        private UserDataRepository UserDataRepository { get; set; }
        public UserController(UserDataRepository userDataRepository, ILogger<UserController> _logger)
        {
            UserDataRepository = userDataRepository;
            logger = _logger;
        }

        [HttpPost("{tgUserId}/start")]
        public IActionResult init(string tgUserId)
        {
            var user_entity = UserConverter.modelToEntity(null, new UserModel { telegramUserId = tgUserId });
            try
            {
                user_entity = UserDataRepository.CreateNewUser(user_entity);
            }
            catch(TelegramUserAlreadyExistsException e)
            {
                logger.LogError(DateTime.Now.ToString() + " User TG[" + tgUserId + "] already exist");
                return BadRequest(e.GetMessageObject());
            }
            catch(UserCreateFailedException e)
            {
                logger.LogError(DateTime.Now.ToString() + " User TG[" + tgUserId + "] create failed");

                return BadRequest(e.GetMessageObject());
            }

            logger.LogInformation(DateTime.Now.ToString() + " User TG[" + tgUserId + "] created");

            return Ok(UserConverter.entityToModel(user_entity, null));
        }

        [HttpPut("{tgUserId}/update")]
        public IActionResult update(string tgUserId, [FromBody] UserDataModel user)
        {
            logger.LogInformation(DateTime.Now.ToString() + " For update entred data: " + JsonConvert.SerializeObject(user).ToString());
            if(user.UserModel != null)
            {
                user.UserModel.telegramUserId = tgUserId;
            }
            else
            {
                user.UserModel = new UserModel { telegramUserId = tgUserId };
            }

            var user_data_entity = UserDataConverter.modelToEntity(null, user);
            try
            {
                user_data_entity = UserDataRepository.UpdateUserData(user_data_entity);
            }
            catch(UserNotFoundException e)
            {
                logger.LogError(DateTime.Now.ToString() + " User TG[" + tgUserId + "] not found");

                return BadRequest(e.GetMessageObject());
            }

            logger.LogInformation(DateTime.Now.ToString() + " User TG[" + tgUserId + "] updated");
            logger.LogInformation("Updated data: " + JsonConvert.SerializeObject(user_data_entity).ToString());
            foreach (var doc in user_data_entity.Documents)
            {
                logger.LogInformation("Documents: " + doc.Name);
            }

            

            return Ok(UserDataConverter.entityToModel(user_data_entity, user));
        }

        [HttpGet("{tgUserId}/data")]
        public IActionResult getUserData(string tgUserId)
        {
            var user_data_entity = new UserDataEntity();
            try
            {
                user_data_entity = UserDataRepository.GetUserData(tgUserId);
            }
            catch(UserNotFoundException e)
            {
                return BadRequest(e.GetMessageObject());
            }

            return Ok(UserDataConverter.entityToModel(user_data_entity, null));
        }

        [HttpDelete("{tgUserId}/delete")]
        public IActionResult removeUserData(string tgUserId)
        {
            try
            {
                UserDataRepository.RemoveUser(tgUserId);
            }
            catch(UserNotFoundException e)
            {
                return BadRequest(e.GetMessageObject());
            }

            return Ok("User " + tgUserId + " deleted");
        }

    }
}