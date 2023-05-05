using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Entities;
using Bygaard.Models;

namespace Bygaard.Services.Interfaces
{
    public interface IStockService
    {
        StockItem Create(StockItemDto model);

        Task<List<StockItem>> GetAllBySubstrate(SimpleStockItemRequest model);
        
        TotalSubstrateStockResponse GetBySubstrate(SimpleStockItemRequest model);

        StockItem Update(StockItemDto model, Guid id);

        StockItem Delete(Guid id);
    }
}