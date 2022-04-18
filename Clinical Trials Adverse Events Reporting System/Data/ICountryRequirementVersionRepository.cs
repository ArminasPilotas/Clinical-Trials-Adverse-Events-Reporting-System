using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface ICountryRequirementVersionRepository
    {
        Task Create(CountryRequirementVersion countryRequirementVersion);

        Task Delete(CountryRequirementVersion countryRequirementVersion);

        Task Update(CountryRequirementVersion countryRequirementVersion);

        Task<CountryRequirementVersion> GetById(int id);

        Task<List<CountryRequirementVersion>> GetByCountry(string countryName);

        Task<List<CountryRequirementVersion>> GetByIPType(int IPTypeId);
    }
}
