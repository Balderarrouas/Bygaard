using System;
using AutoMapper;
using Bygaard.Data;
using Bygaard.Dto;
using Bygaard.Entities;
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
    }
}