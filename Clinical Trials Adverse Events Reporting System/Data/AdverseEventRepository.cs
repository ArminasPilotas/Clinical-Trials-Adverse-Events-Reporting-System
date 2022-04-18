using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class AdverseEventRepository : IAdverseEventRepository
    {
        public readonly CTAERS _dbContext;

        public AdverseEventRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create (AdverseEvent adverseEvent)
        {
            await _dbContext.AddAsync(adverseEvent);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<AdverseEvent> GetById(int id)
        {
            return await _dbContext.AdverseEvents
                .Include(e => e.InvestigationalProductType)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(AdverseEvent adverseEvent)
        {
            _dbContext.AdverseEvents.Update(adverseEvent);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<AdverseEvent>> GetAll()
        {
            return await _dbContext.AdverseEvents
                .Include(e => e.InvestigationalProductType)
                .ToListAsync();
        }
    }
}
