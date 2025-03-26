﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType( typeof(RequestRegisteredUserJson), StatusCodes.Status201Created )]
        public IActionResult Register(RequestRegisteredUserJson request)
        {
            return Created();
;        }
    }
}
