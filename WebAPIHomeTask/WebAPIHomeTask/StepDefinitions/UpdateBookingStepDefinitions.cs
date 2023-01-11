using BL.BaseRequests;
using BL.ResponsesDTO;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace WebAPITests.StepDefinitions
{
    [Binding]
    public class UpdateBookingStepDefinitions
    {
        [Given(@"I update Booking using Put request")]
        public void GivenIUpdateBookingUsingPutRequest()
        {
            var response = RestClientBaseRequests.UpdateBooking();
            ScenarioContext.Current["response"] = response;
        }

        [Then(@"Then I verify first name")]
        public void ThenThenIVerifyFirstName()
        {
            var response = (UpdateBookingResponseDTO)ScenarioContext.Current["response"];
            Assert.AreEqual("James", response.firstname);
        }
    }
}
