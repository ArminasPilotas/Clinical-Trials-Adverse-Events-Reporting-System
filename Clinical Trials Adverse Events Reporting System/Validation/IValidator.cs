using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Validation
{
    public interface IValidator<T>
    {        
        bool Validate(T entity);
    }
}
