using BL.BaseRequests;
using BL.ResponsesDTO;
using NUnit.Framework;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace WebAPITests.StepDefinitions
{
    [Binding]
    public class DeleteBookingStepDefinitions
    {
        [Given(@"I delete Booking using Delete request")]
        public void GivenIDeleteBookingUsingDeleteRequest()
        {
            var response = RestClientBaseRequests.DeleteBooking();
        }

        [Then(@"I verify Booking is deleted")]
        public void ThenIVerifyBookingIsDeleted()
        {
        
        }
    }
}
