using Clinical_Trials_Adverse_Events_Reporting_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Moq;
using MockQueryable.Moq;
using Clinical_Trials_Adverse_Events_Reporting_System.Validation;
using FluentAssertions;

namespace CTAERS_Tests
{
    public class AdverseEventValidatorTests
    {
        [Fact]
        public void Validate_SuccessfulValidateAdverseEvent()
        {
            var adverseEvents = new List<AdverseEvent>()
            {
                new()
                {
                    Id=1,
                    Description = "Mock description",
                    StudyNo = "Mock StudyNo",
                    AttachmentURL = "Mock AttachmentUrl",
                    InvestigationalProductType = new InvestigationalProductType()
                    {
                        Id = 1,
                        Author = "Mock Author",
                        Created = DateTime.UtcNow,
                        Editor = "Mock Editor",
                        Modified = DateTime.UtcNow,
                        ModifyReason = "Mock modify reason",
                        Name = "Some Name"
                    },
                    OccurredOn = DateTime.UtcNow
                }
            };

            var adverseEventToValidate = new AdverseEvent()
            {
                Id = 2,
                Description = "Mock",
                StudyNo = "Mock StudyNo 2",
                AttachmentURL = "Mock",
                InvestigationalProductType = new InvestigationalProductType()
                {
                    Id = 2,
                    Author = "Mock Author",
                    Created = DateTime.UtcNow,
                    Editor = "Mock Editor",
                    Modified = DateTime.UtcNow,
                    ModifyReason = "Mock modify reason",
                    Name = "Some Name"
                },
                OccurredOn = DateTime.UtcNow.AddDays(-1)
        };

            var adverseEventMock = adverseEvents.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.AdverseEvents).Returns(adverseEventMock.Object);

            var adverseEventValidator = new AdverseEventValidator(contextMock.Object);

            var result = adverseEventValidator.Validate(adverseEventToValidate);

            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_PassUniqueValuesForValidation_UnsuccessfulValidation()
        {
            var adverseEvents = new List<AdverseEvent>()
            {
                new()
                {
                    Id=1,
                    Description = "Mock description",
                    StudyNo = "Mock StudyNo",
                    AttachmentURL = "Mock AttachmentUrl",
                    InvestigationalProductType = new InvestigationalProductType()
                    {
                        Id = 1,
                        Author = "Mock Author",
                        Created = DateTime.UtcNow,
                        Editor = "Mock Editor",
                        Modified = DateTime.UtcNow,
                        ModifyReason = "Mock modify reason",
                        Name = "Some Name"
                    },
                    OccurredOn = new DateTime(2022,04,26)
                }
            };

            var adverseEventToValidate = new AdverseEvent()
            {
                Id = 2,
                Description = "Mock description",
                StudyNo = "Mock StudyNo",
                AttachmentURL = "Mock AttachmentUrl",
                InvestigationalProductType = new InvestigationalProductType()
                {
                    Id = 1,
                    Author = "Mock Author",
                    Created = DateTime.UtcNow,
                    Editor = "Mock Editor",
                    Modified = DateTime.UtcNow,
                    ModifyReason = "Mock modify reason",
                    Name = "Some Name"
                },
                OccurredOn = new DateTime(2022, 04, 26)
            };

            var adverseEventMock = adverseEvents.AsQueryable().BuildMockDbSet();

            var contextMock = new Mock<CTAERS>();
            contextMock.Setup(x => x.AdverseEvents).Returns(adverseEventMock.Object);

            var adverseEventValidator = new AdverseEventValidator(contextMock.Object);

            var result = adverseEventValidator.Validate(adverseEventToValidate);

            result.Should().BeFalse();
        }
    }
}
