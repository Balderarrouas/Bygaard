using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<List<Substrate>> GetAll()
        {
            
            var substrateList = _context.Substrates.ToList();

            return substrateList;
        }
        

        public Substrate GetById(Guid id)
        {
            var substrate = _context.Substrates.FirstOrDefault(x => x.SubstrateId == id);

            return substrate;
        }

        public Substrate Update(SubstrateDto model, Guid id)
        {
            var updatedSubstrate = _context.Substrates.SingleOrDefault(x => x.SubstrateId == id);

            updatedSubstrate.Name = model.Name;
            updatedSubstrate.LatinName = model.LatinName;
            updatedSubstrate.DaysToGrow = model.DaysToGrow;
            updatedSubstrate.UpdatedAt = DateTime.Now;
           
            
            _context.Substrates.Update(updatedSubstrate);
            _context.SaveChanges();

            return updatedSubstrate;
        }

        public Substrate Delete(Guid id)
        {
            var substrateToDelete = _context.Substrates.Find(id);
            
            substrateToDelete.DeletedAt = DateTime.Now;

            _context.SaveChanges();

            return substrateToDelete;
        }
    }
}