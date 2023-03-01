using Bygaard.Dto;
using Bygaard.Entities;

namespace Bygaard.Services.Interfaces
{
    public interface ISubstrateService
    {
        Substrate Create(SubstrateDto model);
    }
}