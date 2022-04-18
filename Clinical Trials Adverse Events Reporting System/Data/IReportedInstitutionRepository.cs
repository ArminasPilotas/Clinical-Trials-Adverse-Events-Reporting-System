using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface IReportedInstitutionRepository
    {
        Task Create(AdverseEvent adverseEvent);

        Task<List<ReportedInstitution>> GetAll();

        Task<List<ReportedInstitution>> GetByAdverseEvent(int adverseEventId);

        Task Update(ReportedInstitution reportedInstitution);
    }
}
