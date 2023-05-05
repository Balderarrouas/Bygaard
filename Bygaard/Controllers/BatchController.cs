using System;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bygaard.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class BatchController : Controller
    {

        private readonly IBatchService _batchService;
        
        public BatchController(IBatchService batchService)
        {
            _batchService = batchService;
        }

        [HttpPost]
        public IActionResult Create(BatchDto model)
        {
            var response = _batchService.Create(model);

            return Ok(response);
        }
        

        
    }
}