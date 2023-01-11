using BL.BaseRequests;
using BL.ResponsesDTO;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace WebAPITests.StepDefinitions
{
    [Binding]
    public class CreateBookingStepDefinitions
    {
        [Given(@"I create Booking using Post request")]
        public void GivenICreateBookingUsingPostRequest()
        {
            var response = RestClientBaseRequests.CreateBooking();
            ScenarioContext.Current["response"] = response;
        }

        [Then(@"Then I verify ID")]
        public void ThenThenIVerifyID()
        {
            var response = (CreateBookingResponseDTO)ScenarioContext.Current["response"];
            Assert.AreEqual(1, response.bookingid);
        }
    }
}
