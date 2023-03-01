using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bygaard.Controllers
{
    
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SubstrateController : Controller
    {

        private readonly ISubstrateService _substrateService;

        public SubstrateController(ISubstrateService substrateService)
        {
            _substrateService = substrateService;
        }
        

        [HttpPost]
        public IActionResult CreateSubstrate(SubstrateDto model)
        {
            var response = _substrateService.Create(model);

            return Ok(response);
        }
        
    }
}