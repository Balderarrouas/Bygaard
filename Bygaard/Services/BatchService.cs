using System;
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
    public class BatchService : IBatchService
    {

        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public BatchService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Batch Create(BatchDto model)
        {
            var batch = _mapper.Map<Batch>(model);
            
            batch.CreatedAt = DateTime.Now;
            batch.UpdatedAt = DateTime.Now;
            
            _context.Batches.Add(batch);
            _context.SaveChanges();

            return batch;
        }

        public async Task<List<Batch>> GetAll()
        {
            var batchList = _context.Batches.ToList();

            return batchList;
        }

        public Batch GetById(Guid id)
        {
            var batch = _context.Batches.FirstOrDefault(x => x.BatchId == id);

            return batch;
        }

        public Batch Update(BatchDto model, Guid id)
        {
            var updatedBatch = _context.Batches.SingleOrDefault(x => x.BatchId == id);

            updatedBatch.Substrate = model.Substrate;
            updatedBatch.KilosOfSubstrate = model.KilosOfSubstrate;
            updatedBatch.KilosOfProduce = model.KilosOfProduce;
            updatedBatch.UpdatedAt = DateTime.Now;

            _context.Batches.Update(updatedBatch);
            _context.SaveChanges();

            return updatedBatch;
        }

        public Batch Delete(Guid id)
        {
            var batchToDelete = _context.Batches.Find(id);
            
            batchToDelete.DeletedAt = DateTime.Now;

            _context.SaveChanges();

            return batchToDelete;
        }

        public AverageResponse GetAverage(AverageRequest model)
        {
            var averageObj = new AverageResponse();

            var substratesToAverageList = _context.Batches.Where(x => x.Substrate == model.SubstrateName).ToList();

            foreach (var substrateItem in substratesToAverageList)
            {
                averageObj.TotalSubstrate += substrateItem.KilosOfSubstrate;
                averageObj.TotalProduce += substrateItem.KilosOfProduce;
            }

            averageObj.AverageProducePerKiloOfSubstrate = averageObj.TotalProduce / averageObj.TotalSubstrate;

            return averageObj;
        }

        public RequiredSubstrateResponse CalculateAmount(RequiredSubstrateRequest model)
        {
            var average = new AverageRequest();
            average.SubstrateName = model.SubstrateName;

            var averageOfProduce = GetAverage(average);

            var requiredSubstrate = new RequiredSubstrateResponse();

            requiredSubstrate.SubstrateName = model.SubstrateName;
            requiredSubstrate.KilosOfSubstrate =
                model.RequiredProduce / averageOfProduce.AverageProducePerKiloOfSubstrate;

            return requiredSubstrate;
        }
    }
}