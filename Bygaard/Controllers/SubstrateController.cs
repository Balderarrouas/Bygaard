using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Entities;
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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _substrateService.GetAll();

            return Ok(response);
        }

        [HttpGet("/GetSubstrateById/{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var response = _substrateService.GetById(id);

            return Ok(response);
        }

        [HttpPut("/UpdateSubstrate/{id:guid}")]
        public IActionResult Update(SubstrateDto model, Guid id)
        {
            var response = _substrateService.Update(model, id);

            return Ok(response);
        }

        [HttpDelete("/DeleteSubstrate/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var response = _substrateService.Delete(id);

            return Ok(response);
        }
    }
}