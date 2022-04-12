using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class ReportedInstitutionRepository
    {
        public readonly CTAERS _dbContext;

        public ReportedInstitutionRepository(CTAERS dbContext)
        {
            _dbContext = dbContext;
        }

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
                    && natReq.Valid == true)
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

        public async Task<List<ReportedInstitution>> GetAll()
        {
            return await _dbContext.ReportedInstitutions
                .Include(c => c.AdverseEvent)
                .ToListAsync();
        }

        public async Task<List<ReportedInstitution>> GetByAdverseEvent(int id)
        {
            return await _dbContext.ReportedInstitutions
                .Where(c => c.AdverseEvent.Id == id)
                .Include(c => c.Institution.Country)
                .Include(c => c.Institution.InstitutionType                )
                .ToListAsync();
        }

        public async Task Update(ReportedInstitution reportedInstitution)
        {
            reportedInstitution.ReportedOn = DateTime.UtcNow;
            _dbContext.ReportedInstitutions.Update(reportedInstitution);
            await _dbContext.SaveChangesAsync();
        }

    }
}
