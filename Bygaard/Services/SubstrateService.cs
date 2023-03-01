using System;
using AutoMapper;
using Bygaard.Data;
using Bygaard.Dto;
using Bygaard.Entities;
using Bygaard.Services.Interfaces;

namespace Bygaard.Services
{
    
    
    public class SubstrateService : ISubstrateService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public SubstrateService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public Substrate Create(SubstrateDto model)
        {
            var substrate = _mapper.Map<Substrate>(model);
            substrate.CreatedAt = DateTime.Now;
            substrate.UpdatedAt = DateTime.Now;
            
            _context.Substrates.Add(substrate);
            _context.SaveChanges();
            
            return substrate;
        }
    }
}