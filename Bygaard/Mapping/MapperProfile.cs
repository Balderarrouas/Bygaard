using AutoMapper;
using Bygaard.Dto;
using Bygaard.Entities;

namespace Bygaard.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<SubstrateDto, Substrate>();
            CreateMap<Substrate, SubstrateDto>();
            CreateMap<StockItemDto, StockItem>();
            CreateMap<StockItem, StockItemDto>();
            CreateMap<Batch, BatchDto>();
            CreateMap<BatchDto, Batch>();
        }
    }
}