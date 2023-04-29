using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Entities;
using Bygaard.Models;
using Bygaard.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bygaard.Controllers
{
    
    
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : Controller
    {

        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpPost]
        public IActionResult Create(StockItemDto model)
        {
            var response = _stockService.Create(model);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBySubstrate(SimpleStockItemRequest model)
        {
            var response = await _stockService.GetAllBySubstrate(model
            );

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetBySubstrate(SimpleStockItemRequest model)
        {
            var response = _stockService.GetBySubstrate(model);

            return Ok(response);
        }

        [HttpPut("/{id:guid}")]
        public IActionResult Update(StockItemDto model, Guid id)
        {
            var response = _stockService.Update(model, id);

            return Ok(response);
        }

        [HttpDelete("/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            var response = _stockService.Delete(id);

            return Ok(response);
        }




    }
}