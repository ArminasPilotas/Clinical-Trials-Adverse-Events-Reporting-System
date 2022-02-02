using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Data
{
    public class ClassifierService
    {
        private readonly CTAERS Ctaers; //app db context
       
        public ClassifierService(CTAERS Ctaers)
        {
            this.Ctaers = Ctaers;
        }

        public async Task<List<Classifier>> GetAllClassifiersAsync()
        {
            return await Ctaers.Classifiers.ToListAsync();
        }

        public async Task<bool> InsertClassifierAsync(Classifier classifier)
        {
            await Ctaers.Classifiers.AddAsync(classifier);
            await Ctaers.SaveChangesAsync();
            return true;
        }

        public async Task<Classifier> GetClassifierAsync(int Id)
        {
            Classifier classifier = await Ctaers.Classifiers.FirstOrDefaultAsync(x => x.Id.Equals(Id));
            return classifier;
        }

        public async Task<bool> UpdateClassifierAsync(Classifier classifier)
        {
            Ctaers.Classifiers.Update(classifier);
            await Ctaers.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteClassifierAsync(Classifier classifier)
        {
            Ctaers.Remove(classifier);
            await Ctaers.SaveChangesAsync();
            return true;
        }

    }
}
