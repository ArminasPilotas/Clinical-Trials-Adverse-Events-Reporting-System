using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface IAdverseEventRepository
    {
        Task Create(AdverseEvent adverseEvent);

        Task<AdverseEvent> GetById(int id);

        Task Update(AdverseEvent adverseEvent);

        Task<List<AdverseEvent>> GetAll();
    }
}
