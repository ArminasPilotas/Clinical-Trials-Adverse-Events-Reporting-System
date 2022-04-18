using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface INationalRequirementVersionRepository
    {
        Task Create(NationalRequirementVersion nationalRequirementVersion);

        Task<NationalRequirementVersion> GetByNationalRequirement(int nationalRequirementId);

        Task<List<NationalRequirementVersion>> GetAll();

        Task Update(NationalRequirementVersion nationalRequirementVersion);
    }
}
