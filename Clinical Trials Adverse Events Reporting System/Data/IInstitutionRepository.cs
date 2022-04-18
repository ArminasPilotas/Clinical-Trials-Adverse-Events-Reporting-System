using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface IInstitutionRepository
    {
        Task Create(Institution institution);

        Task Delete(Institution institution);

        Task<List<Institution>> GetByCountry(string countryName);

        Task<Institution> GetById(int id);

        Task Update(Institution institution);
    }
}
