using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface INationalRequirementsRepository
    {
        Task Create(NationalRequirement nationalRequirement);

        Task Delete(NationalRequirement nationalRequirement);

        Task<List<NationalRequirement>> GetByCountry(string countryName);

        Task<NationalRequirement> GetById(int id);

        Task Update(NationalRequirement nationalRequirement);
    }
}
