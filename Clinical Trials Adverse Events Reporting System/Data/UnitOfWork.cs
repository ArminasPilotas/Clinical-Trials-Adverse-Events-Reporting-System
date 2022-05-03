using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private IDbContextTransaction transaction;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public async Task BeginTransactionAsync()
        {
            transaction = await this.context.Database.BeginTransactionAsync();
        }

        public async Task CloseTransactionAsync()
        {
            await this.transaction.DisposeAsync();
        }

        public async Task CommitAsync()
        {
            await this.transaction.CommitAsync();
        }

        public async Task CompleteAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public async Task RollbackAsync()
        {
            await this.transaction.RollbackAsync();
        }
    }
}
