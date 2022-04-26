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
    public class InstitutionValidatorTests
    {
        [Fact]
        public void Validate_SuccessfulValidateInstitution()
        {
            var institutions = new List<Institution>()
            {
                new()
                {
                    Id = 1,
                    Name = "Mock Name 1"
                }
            };

            var institutionToValidate = new Institution()
            {
                Id = 2,
                Name = "Mock Name 2"
            };

            var institutionMock = institutions.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.Institutions).Returns(institutionMock.Object);

            var institutionValidator = new InstitutionValidator(contextMock.Object);

            var result = institutionValidator.Validate(institutionToValidate);

            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_PassUniqueInstitutionName_UnsuccessfulValidation()
        {
            var institutions = new List<Institution>()
            {
                new()
                {
                    Id = 1,
                    Name = "Mock Institution Name"
                }
            };

            var institutionToValidate = new Institution()
            {
                Id = 2,
                Name = "Mock Institution Name"
            };

            var institutionMock = institutions.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.Institutions).Returns(institutionMock.Object);

            var institutionValidator = new InstitutionValidator(contextMock.Object);

            var result = institutionValidator.Validate(institutionToValidate);

            result.Should().BeFalse();
        }
    }
}
