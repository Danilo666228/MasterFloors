using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFloor.Models.Repositories
{
    public class PartnerTypeRepository
    {
        private readonly MasterFloorDbContext _dbContext;
        public PartnerTypeRepository(MasterFloorDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<PartnerType>> GetPartnerTypes() => await _dbContext.PartnerTypes.ToListAsync();
    }
}
