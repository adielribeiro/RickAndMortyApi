using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rm.API.Services;

namespace Rm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharController : ControllerBase
    {
        private readonly iCharServices _charService;

        public CharController(iCharServices charServices)
        {
            _charService = charServices;
        }

        [HttpGet()]
        public async Task<IActionResult> Get(int id)
        {
            var charRetorno = await _charService.GetCharById(id);
            return Ok(charRetorno);
        }

    }
}