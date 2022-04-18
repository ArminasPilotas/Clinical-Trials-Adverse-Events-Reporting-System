using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface IAuthorityRepository
    {
        Task Create(Authority authority);

        Task Delete(Authority authority);

        Task<List<Authority>> GetByCountry(string countryName);

        Task<Authority> GetById(int id);

        Task Update(Authority authority);



    }
}
