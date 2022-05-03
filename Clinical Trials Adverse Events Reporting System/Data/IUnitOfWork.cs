using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();

        Task BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();

        Task CloseTransactionAsync();
    }
}
