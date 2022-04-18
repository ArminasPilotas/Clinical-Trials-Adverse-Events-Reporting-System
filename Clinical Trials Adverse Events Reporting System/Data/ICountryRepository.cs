using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAll();

        Task<Country> GetById(int id);

        Task<Country> GetByName(string Name);
    }
}
