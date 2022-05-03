using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Adverse Event repository is the main logic for access data from the database
    /// </summary>
    public class AdverseEventRepository : IAdverseEventRepository
    {
        public readonly AppDbContext _dbContext;
        private readonly ILogger _logger;

        public AdverseEventRepository(AppDbContext dbContext, ILogger<AdverseEventRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        /// <summary>
        /// Method adds adverse event object to the database
        /// </summary>
        /// <param name="adverseEvent"></param>
        /// <returns></returns>
        public async Task Create (AdverseEvent adverseEvent)
        {
            await _dbContext.AddAsync(adverseEvent);
            await _dbContext.SaveChangesAsync();
            _logger.LogInformation("Adverse Event is created");
        }
        /// <summary>
        /// Method helps to get adverse event from database based by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<AdverseEvent> GetById(int id)
        {
            return await _dbContext.AdverseEvents
                .Include(e => e.InvestigationalProductType)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        /// <summary>
        /// Method updates adverse event object in the database
        /// </summary>
        /// <param name="adverseEvent"></param>
        /// <returns></returns>
        public async Task Update(AdverseEvent adverseEvent)
        {
            _dbContext.AdverseEvents.Update(adverseEvent);
            await _dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// Method helps to get all adverse event objects from the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<AdverseEvent>> GetAll()
        {
            return await _dbContext.AdverseEvents
                .Include(e => e.InvestigationalProductType)
                .ToListAsync();
        }
    }
}
