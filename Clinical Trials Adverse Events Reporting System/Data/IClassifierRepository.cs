﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
   public interface IClassifierRepository<TEntity>
        where TEntity : Classifier
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(int id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TEntity entity);
    }
}
