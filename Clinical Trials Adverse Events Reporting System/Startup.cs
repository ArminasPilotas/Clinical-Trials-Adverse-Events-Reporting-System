using Clinical_Trials_Adverse_Events_Reporting_System.Data;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Clinical_Trials_Adverse_Events_Reporting_System.Validation;
using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Microsoft.Extensions.Options;
using Clinical_Trials_Adverse_Events_Reporting_System.Utilities;
using Microsoft.AspNetCore.Components.Authorization;

namespace Clinical_Trials_Adverse_Events_Reporting_System
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDbContext<AppDbContext>(item => item
                .UseSqlServer(Configuration.GetConnectionString("myconn"))
                .LogTo(Console.WriteLine));
            services.AddAuthentication((opts) =>
            {
                opts.AddScheme("DocRegScheme", builder =>
                {
                    builder.HandlerType = typeof(WebAppAuthHandler);
                });
            });

            var docregconf = Configuration.GetSection("WebAppAuthConfiguration");

            services.Configure<WebAppAuthConfiguration>(docregconf);
            services.AddSingleton<WebAppAuthConfiguration>(s =>
            s.GetRequiredService<IOptions<WebAppAuthConfiguration>>().Value);

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SystemAuthorization", (policy) =>
                {
                    policy.RequireAssertion(AuthUtil.AssertSystemAuthorizationPolicy);
                });
            });

            services.AddScoped<AuthenticationStateProvider, WebAppAuthStateProvider>();

            services.AddScoped(typeof(IClassifierRepository<>), typeof(ClassifierRepository<>));
            services.AddScoped<ICountryRepository,CountryRepository>();
            services.AddScoped<IInstitutionRepository,InstitutionRepository>();
            services.AddScoped<INationalRequirementsRepository,NationalRequirementsRepository>();
            services.AddScoped<IAuthorityRepository,AuthorityRepository>();
            services.AddScoped<ICountryRequirementVersionRepository,CountryRequirementVersionRepository>();
            services.AddScoped<INationalRequirementVersionRepository,NationalRequirementVersionRepository>();
            services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
            services.AddScoped(typeof(IValidator<Authority>), typeof(AuthorityValidator));
            services.AddScoped(typeof(IValidator<Institution>), typeof(InstitutionValidator));
            services.AddScoped(typeof(IValidator<CountryRequirementVersion>), typeof(CountryRequirementVersionValidator));
            services.AddScoped(typeof(IValidator<>), typeof(ClassifierValidator<>));
            services.AddScoped(typeof(IValidator<AdverseEvent>), typeof(AdverseEventValidator));
            services.AddScoped(typeof(IValidator<NationalRequirement>), typeof(NationalRequirementValidator));
            services.AddScoped<IAdverseEventRepository,AdverseEventRepository>();
            services.AddScoped<IReportedInstitutionRepository,ReportedInstitutionRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
