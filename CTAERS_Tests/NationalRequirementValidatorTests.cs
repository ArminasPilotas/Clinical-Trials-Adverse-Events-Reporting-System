using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using Clinical_Trials_Adverse_Events_Reporting_System.Validation;
using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CTAERS_Tests
{
    public class NationalRequirementValidatorTests
    {
        [Fact]
        public void Validate_SuccessfulValidateNationalRequirement()
        {
            var nationalRequirements = new List<NationalRequirement>()
            {
                new()
                {
                    Id = 1,
                    InstitutionType = new InstitutionType()
                    {
                        Id= 1
                    },
                    InvestigationalProductType = new InvestigationalProductType()
                    {
                        Id= 1
                    },
                    ReportingType = new ReportingType()
                    {
                        Id = 1
                    },
                    ReportType = new ReportType()
                    {
                        Id = 1
                    },
                    SusarType = new SusarType()
                    {
                        Id = 1
                    },
                    CaseOrigin = new CaseOrigin()
                    {
                        Id = 1
                    }
                }
            };

            var nationalRequirementToValidate = new NationalRequirement()
            {
                Id = 2,
                InstitutionType = new InstitutionType()
                {
                    Id = 2
                },
                InvestigationalProductType = new InvestigationalProductType()
                {
                    Id = 2
                },
                ReportingType = new ReportingType()
                {
                    Id = 2
                },
                ReportType = new ReportType()
                {
                    Id = 2
                },
                SusarType = new SusarType()
                {
                    Id = 2
                },
                CaseOrigin = new CaseOrigin()
                {
                    Id = 2
                }
            };

            var nationalRequirementMock = nationalRequirements.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.NationalRequirements).Returns(nationalRequirementMock.Object);

            var nationalRequirementValidator = new NationalRequirementValidator(contextMock.Object);

            var result = nationalRequirementValidator.Validate(nationalRequirementToValidate);

            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_PassUniqueValuesForValidation_UnsuccessfulValidation()
        {
            var institutionType = new InstitutionType()
            {
                Id = 1
            };

            var investigationalProductType = new InvestigationalProductType()
            {
                Id = 1
            };

            var reportingType = new ReportingType()
            {
                Id = 1
            };

            var reportType = new ReportType()
            {
                Id = 1
            };

            var caseOrigin = new CaseOrigin()
            {
                Id = 1
            };

            var nationalRequirements = new List<NationalRequirement>()
            {
                new()
                {
                    Id = 1,
                    InstitutionType = institutionType,
                    InvestigationalProductType = investigationalProductType,
                    ReportingType = reportingType,
                    ReportType = reportType,
                    CaseOrigin = caseOrigin
                }
            };

            var nationalRequirementToValidate = new NationalRequirement()
            {
                Id = 2,
                InstitutionType = institutionType,
                InvestigationalProductType = investigationalProductType,
                ReportingType = reportingType,
                ReportType = reportType,
                CaseOrigin = caseOrigin
            };

            var nationalRequirementMock = nationalRequirements.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.NationalRequirements).Returns(nationalRequirementMock.Object);

            var nationalRequirementValidator = new NationalRequirementValidator(contextMock.Object);

            var result = nationalRequirementValidator.Validate(nationalRequirementToValidate);

            result.Should().BeFalse();
        }
    }
}
