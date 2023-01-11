using BL.BaseRequests;
using BL.ResponsesDTO;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace WebAPITests.StepDefinitions
{
    [Binding]
    public class GetBookingStepDefinitions
    {
        [Given(@"I get Booking using Get request")]
        public void GivenIGetBookingUsingGetRequest()
        {
            var response = RestClientBaseRequests.GetBooking();
            ScenarioContext.Current["response"] = response;
        }

        [Then(@"I verify first name")]
        public void ThenIVerifyFirstName()
        {
            var response = (GetBookingResponseDTO)ScenarioContext.Current["response"];
            Assert.AreEqual("Sally", response.firstname);
        }
    }
}
