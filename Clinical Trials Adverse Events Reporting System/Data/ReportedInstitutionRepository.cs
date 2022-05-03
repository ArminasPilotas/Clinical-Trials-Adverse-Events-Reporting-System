using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    /// <summary>
    /// Reported institution repository is the main logic for access data from the database
    /// </summary>
    public class ReportedInstitutionRepository : IReportedInstitutionRepository
    {
        public readonly AppDbContext _dbContext;

        public ReportedInstitutionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Creates reported institutions and adds to the database based by adverse event. Firstly institutions is picked where study number is equals with adverse event study number and registration number is not empty
        /// Then first national requirement is picked based by reported institutions type, country and investigational product type. If national requiremnt is found we add reported institution to the database
        /// </summary>
        /// <param name="adverseEvent"></param>
        /// <returns></returns>
        public async Task Create (AdverseEvent adverseEvent)
        {
            List<Institution> institutions = new List<Institution>();
            institutions.AddRange(await _dbContext.Institutions
                .Include(institution => institution.InstitutionType)
                .Include(Institution => Institution.Country)
                .Where(institution => institution.StudyNumber == adverseEvent.StudyNo && !string.IsNullOrEmpty(institution.RegNo))
                .ToListAsync());

            institutions.AddRange(await _dbContext.Authorities
                .Include(authority => authority.Institution.InstitutionType)
                .Include(authority => authority.Institution.Country)
                .Where(authority => authority.InvestigationalProductType.Id == adverseEvent.InvestigationalProductType.Id && authority.Institution.RegNo == null)
                .Select(authority => authority.Institution)
                .ToListAsync());

            foreach(var institution in institutions.Distinct())
            {
                NationalRequirement nationalRequirement = await _dbContext.NationalRequirements
                    .Where(natReq => natReq.InstitutionType.Id == institution.InstitutionType.Id
                    && natReq.InvestigationalProductType.Id == adverseEvent.InvestigationalProductType.Id
                    && natReq.Country.Id == institution.Country.Id
                    && natReq.Valid)
                    .FirstOrDefaultAsync();

                if (nationalRequirement != null)
                {
                    ReportedInstitution reportedInstitution = new ReportedInstitution();
                    reportedInstitution.AdverseEvent = adverseEvent;
                    reportedInstitution.Institution = institution;
                    reportedInstitution.ReportBy = adverseEvent.OccurredOn.AddDays(nationalRequirement.Days);

                    await _dbContext.AddAsync(reportedInstitution);
                }
            }
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method helps to get all reported institutions from the database
        /// </summary>
        /// <returns></returns>
        public async Task<List<ReportedInstitution>> GetAll()
        {
            return await _dbContext.ReportedInstitutions
                .Include(c => c.AdverseEvent)
                .ToListAsync();
        }
        /// <summary>
        /// Method helps to get reported institutions based by adverse event Id
        /// </summary>
        /// <param name="adverseEventId"></param>
        /// <returns></returns>
        public async Task<List<ReportedInstitution>> GetByAdverseEvent(int adverseEventId)
        {
            return await _dbContext.ReportedInstitutions
                .Where(c => c.AdverseEvent.Id == adverseEventId)
                .Include(c => c.Institution.Country)
                .Include(c => c.Institution.InstitutionType                )
                .ToListAsync();
        }

        /// <summary>
        /// Method updates reported institution object in the database
        /// </summary>
        /// <param name="reportedInstitution"></param>
        /// <returns></returns>
        public async Task Update(ReportedInstitution reportedInstitution)
        {
            reportedInstitution.ReportedOn = DateTime.UtcNow;
            _dbContext.ReportedInstitutions.Update(reportedInstitution);
            await _dbContext.SaveChangesAsync();
        }

    }
}
