using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Entities;

namespace Bygaard.Services.Interfaces
{
    public interface ISubstrateService
    {
        Substrate Create(SubstrateDto model);
        Task<List<Substrate>> GetAll();

        Substrate GetById(Guid id);

        Substrate Update(SubstrateDto model, Guid id);

        Substrate Delete(Guid id);
    }
}