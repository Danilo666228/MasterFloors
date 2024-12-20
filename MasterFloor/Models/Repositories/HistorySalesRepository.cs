using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFloor.Models.Repositories
{
    public class HistorySalesRepository
    {
        private readonly MasterFloorDbContext _dbContext;
        public HistorySalesRepository(MasterFloorDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<HistorySale>> GetHistorySaleByPartner(int partnerId)
        {
            return await _dbContext.HistorySales.Where(c => c.PartnerId == partnerId).ToListAsync();
        }
        public async Task<List<double>> GetQuantitySales(double partnerId)
        {
           return _dbContext.HistorySales.Where(c => c.PartnerId == partnerId).Select(c=> c.Quantity).ToList();
        }
    }
}
