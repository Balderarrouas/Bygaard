using Bygaard.Dto;
using Bygaard.Entities;

namespace Bygaard.Services.Interfaces
{
    public interface IBatchService
    {
        Batch Create(BatchDto model);
    }
}