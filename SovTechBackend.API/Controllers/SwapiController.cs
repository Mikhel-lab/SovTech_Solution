using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SovTechBackend.Model.DTOs;
using SovTechBackend.Service.People;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SovTechBackend.API.Controllers
{
    [ApiController]
    [Route("swap")]
    public class SwapiController : Controller
    {
        private IPeopleService _service;
        public SwapiController(IPeopleService service)
        {
            _service = service;
        }
        [HttpGet("/allpeople")]
        public async Task<IActionResult> GetSwapiPeople()
        {
            var categories = await _service.GetSwapiPeopleAsync();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }


       
    }
}
