using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Utilities
{
    /// <summary>
    /// Data attribute class helps to validate user picked data
    /// </summary>
    public class DateAttribute : RangeAttribute
    {
        public DateAttribute()
        : base(typeof(DateTime), DateTime.Now.AddYears(-20).ToString(), DateTime.Now.ToString()) { }
    }
}
