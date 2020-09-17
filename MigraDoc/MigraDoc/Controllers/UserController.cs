using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using MigraDoc.Core.Converters;
using MigraDoc.WebAPI.CRUD;
using Com.SNGJob.Core.Exceptions;

namespace MigraDoc.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserDataConverter UserDataConverter = new UserDataConverter();
        private UserConverter UserConverter = new UserConverter();
        private UserDataRepository UserDataRepository { get; set; }
        public UserController(UserDataRepository userDataRepository)
        {
            UserDataRepository = userDataRepository;
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
                return BadRequest(e.GetMessageObject());
            }
            catch(UserCreateFailedException e)
            {
                return BadRequest(e.GetMessageObject());
            }


            return Ok(UserConverter.entityToModel(user_entity, null));
        }

        [HttpPut("{tgUserId}/update")]
        public IActionResult update(string tgUserId, [FromBody] UserDataModel user)
        {
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
                return BadRequest(e.GetMessageObject());
            }

            return Ok(UserDataConverter.entityToModel(user_data_entity, user));
        }

        [HttpGet("{tgUserId}")]
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

    }
}