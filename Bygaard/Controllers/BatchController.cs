using System;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Models;
using Bygaard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost("/GetAverage")]
        public IActionResult GetAverage(AverageRequest model)
        {
            var response = _batchService.GetAverage(model);

            return Ok(response);
        }

        [HttpPost("/GetRequiredAmountOfSubstrate")]
        public IActionResult CalculateAmount(RequiredSubstrateRequest model)
        {
            var response = _batchService.CalculateAmount(model);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _batchService.GetAll();

            return Ok(response);
        }

        [HttpGet("/{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var response = _batchService.GetById(id);

            return Ok(response);
        }

        [HttpPut("/{id:guid}")]
        public IActionResult Update(BatchDto model, Guid id)
        {
            var response = _batchService.Update(model, id);

            return Ok(response);
        }

        [HttpDelete("/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var response = _batchService.Delete(id);

            return Ok(response);
        }
    }
}