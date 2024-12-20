using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFloor.Models.Repositories
{
    public class PartnerRepository
    {
        private readonly MasterFloorDbContext _dbContext;
        public PartnerRepository(MasterFloorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Partner>> GetPartners() => await _dbContext.Partners.Include(c=> c.PartnerType).ToListAsync();
        public async Task<bool> EditPartner(int partnerId,string partnerName,string partnerPhone,string partnerAddress,string partnerDirector,int partnerTypeId)
        {
            var currentPartner = await _dbContext.Partners
                .Include(c=> c.PartnerType)
                .FirstOrDefaultAsync(c=> c.IdPartner == partnerId);

            if (currentPartner != null)
            {
                currentPartner.PartnerName = partnerName;
                currentPartner.PartnerTypeId = partnerTypeId;
                currentPartner.PartnerPhone = partnerPhone;
                currentPartner.PartnerAddress = partnerAddress;
                currentPartner.DirectorName = partnerDirector;
                await _dbContext.SaveChangesAsync();

                return true;   
            }
            return false;
        }
        public async Task AddPartner(string partnerName,string partnerPhone,string partnerAddress, string partnerDirector,int partnerTypeId,string partnerEmail,string partnerTaxpayeer,int partnerRating)
        {
            var NewUser = new Partner()
            {
                PartnerName = partnerName,
                PartnerPhone = partnerPhone,
                PartnerAddress = partnerAddress,
                DirectorName = partnerDirector,
                PartnerTypeId = partnerTypeId,
                PartnerEmail = partnerEmail,
                PartnerRating = partnerRating,
                TaxpayerNumber = partnerTaxpayeer
            };
            _dbContext.Partners.Add(NewUser);
            await _dbContext.SaveChangesAsync();
           
        }
    }
}
