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
    public class CountryRequirementVersionValidatorTests
    {
        [Fact]
        public void Validate_SuccessfulValidateCountryRequirementVersion()
        {
            var countryRequirementVersions = new List<CountryRequirementVersion>()
            {
                new()
                {
                    Id = 1,
                    InvestigationalProductType = new InvestigationalProductType()
                    {
                        Id=1
                    },
                    ContactRevisionDate = DateTime.UtcNow,
                    ContactVersion = "1.0",
                    DateOfRenewal = DateTime.UtcNow,
                    RequirementVersion = "1.0",
                }
            };

            var countryRequirementVersionToValidate = new CountryRequirementVersion()
            {
                Id = 2,
                InvestigationalProductType = new InvestigationalProductType()
                {
                    Id = 2
                },
                ContactRevisionDate = DateTime.UtcNow,
                ContactVersion = "2.0",
                DateOfRenewal = DateTime.UtcNow,
                RequirementVersion = "2.0"
            };

            var countryRequirementVersionMock = countryRequirementVersions.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.CountryRequirementVersions).Returns(countryRequirementVersionMock.Object);

            var countryRequirementVersionValidator = new CountryRequirementVersionValidator(contextMock.Object);

            var result = countryRequirementVersionValidator.Validate(countryRequirementVersionToValidate);

            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_PassUniqueValuesForValidation_UnsuccessfulValidation()
        {
            var investigationalProductType = new InvestigationalProductType()
            {
                Id = 1
            };

            var countryRequirementVersions = new List<CountryRequirementVersion>()
            {
                new()
                {
                    Id = 1,
                    InvestigationalProductType = investigationalProductType,
                    ContactRevisionDate = DateTime.UtcNow,
                    ContactVersion = "1.0",
                    DateOfRenewal = DateTime.UtcNow,
                    RequirementVersion = "1.0",
                }
            };

            var countryRequirementVersionToValidate = new CountryRequirementVersion()
            {
                Id = 2,
                InvestigationalProductType = investigationalProductType,
                ContactRevisionDate = DateTime.UtcNow,
                ContactVersion = "1.0",
                DateOfRenewal = DateTime.UtcNow,
                RequirementVersion = "1.0"
            };

            var countryRequirementVersionMock = countryRequirementVersions.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.CountryRequirementVersions).Returns(countryRequirementVersionMock.Object);

            var countryRequirementVersionValidator = new CountryRequirementVersionValidator(contextMock.Object);

            var result = countryRequirementVersionValidator.Validate(countryRequirementVersionToValidate);

            result.Should().BeFalse();

        }
    }
}
