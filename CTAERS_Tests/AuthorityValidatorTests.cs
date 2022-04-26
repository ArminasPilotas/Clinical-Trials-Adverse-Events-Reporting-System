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
    public class AuthorityValidatorTests
    {
        [Fact]
        public void Validate_SuccessfulValidateAuthority()
        {
            var authorities = new List<Authority>()
            {
                new ()
                {
                    Id = 1,
                    Created = DateTime.UtcNow,
                    Editor = "Mock Editor",
                    Modified = DateTime.UtcNow,
                    Author = "Mock Author",
                    Country = new Country(),
                    Institution = new Institution()
                    {
                        Id = 1
                    },
                    InstitutionType = new InstitutionType()
                    {
                        Id = 1
                    },
                    InvestigationalProductType = new InvestigationalProductType()
                    {
                        Id = 1
                    }
                }
            };

            var authorityToValidate = new Authority()
            {
                Id = 2,
                Institution = new Institution()
                {
                    Id = 2
                },
                InstitutionType = new InstitutionType()
                {
                    Id = 2
                },
                InvestigationalProductType = new InvestigationalProductType()
                {
                    Id = 2
                }
            };

            var authorityMock = authorities.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.Authorities).Returns(authorityMock.Object);

            var authorityValidator = new AuthorityValidator(contextMock.Object);

            var result = authorityValidator.Validate(authorityToValidate);

            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_PassUniqueValuesForValidation_UnsuccessfulValidation()
        {
            var institution = new Institution()
            {
                Id = 1
            };

            var institutionType = new InstitutionType()
            {
                Id = 1
            };

            var investigationalProductType = new InvestigationalProductType()
            {
                Id = 1
            };

            var authorities = new List<Authority>()
            {
                new ()
                {
                    Id = 1,
                    Institution = institution,
                    InstitutionType = institutionType,
                    InvestigationalProductType = investigationalProductType
                }
            };

            var authorityToValidate = new Authority()
            {
                Id = 2,
                Institution = institution,
                InstitutionType = institutionType,
                InvestigationalProductType = investigationalProductType
            };

            var authorityMock = authorities.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.Authorities).Returns(authorityMock.Object);

            var authorityValidator = new AuthorityValidator(contextMock.Object);

            var result = authorityValidator.Validate(authorityToValidate);

            result.Should().BeFalse();
        }
    }
}
