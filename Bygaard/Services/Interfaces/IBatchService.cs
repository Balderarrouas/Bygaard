using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bygaard.Dto;
using Bygaard.Entities;
using Bygaard.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bygaard.Services.Interfaces
{
    public interface IBatchService
    {
        Batch Create(BatchDto model);

        Task<List<Batch>> GetAll();

        Batch GetById(Guid id);

        Batch Update(BatchDto model, Guid id);

        Batch Delete(Guid id);

        AverageResponse GetAverage(AverageRequest model);

        RequiredSubstrateResponse CalculateAmount(RequiredSubstrateRequest model);
    }
}