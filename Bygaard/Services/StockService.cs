﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bygaard.Data;
using Bygaard.Dto;
using Bygaard.Entities;
using Bygaard.Models;
using Bygaard.Services.Interfaces;

namespace Bygaard.Services
{
    public class StockService : IStockService
    {
        
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public StockService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public StockItem Create(StockItemDto model)
        {
            var stockItem = _mapper.Map<StockItem>(model);

            _context.StockItems.Add(stockItem);
            _context.SaveChanges();

            return stockItem;
        }

        public async Task<List<StockItem>> GetAllBySubstrate(SimpleStockItemRequest model)
        {
            var stockItemList = _context.StockItems.ToList();

            return stockItemList;
        }

        public StockItem GetBySubstrate(SimpleStockItemRequest model)
        {
            var stockItemBySubstrate = _context.StockItems.FirstOrDefault(x => x.SubstrateName == model.SubstrateNamme);

            return stockItemBySubstrate;
        }

        public StockItem Update(StockItemDto model, Guid id)
        {
            var updatedStockItem = _context.StockItems.SingleOrDefault(x => x.StockItemId == id);

            updatedStockItem.SubstrateName = model.SubstrateName;
            updatedStockItem.Amount = model.Amount;
            updatedStockItem.UpdatedAt = DateTime.Now;

            _context.StockItems.Update(updatedStockItem);
            _context.SaveChanges();
            
            return updatedStockItem;
        }

        public StockItem Delete(Guid id)
        {
            var stockItemToDelete = _context.StockItems.Find(id);
            
            stockItemToDelete.DeletedAt = DateTime.Now;

            _context.SaveChanges();

            return stockItemToDelete;
        }
        
        


    }
}