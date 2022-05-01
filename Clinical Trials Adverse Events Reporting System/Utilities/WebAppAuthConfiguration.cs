using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Utilities
{
    public class WebAppAuthConfiguration
    {
        private readonly IConfiguration Configuration;

        public WebAppAuthConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
