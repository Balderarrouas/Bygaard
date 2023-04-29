using AutoMapper;
using Bygaard.Data;
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
    }
}