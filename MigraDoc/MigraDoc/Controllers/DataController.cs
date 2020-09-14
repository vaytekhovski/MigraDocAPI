using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;

namespace MigraDoc.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpPost("start/{tgUserId}")]
        public IActionResult init(string tgUserId)
        {

            return Ok();
        }

        [HttpPost("update/{tgUserId}")]
        public IActionResult update(string tgUserId, [FromBody] UserDataModel user)
        {
            return Ok();
        }

    }
}