using BL.BaseRequests;
using BL.ResponsesDTO;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace WebAPITests.StepDefinitions
{
    [Binding]
    public class AuthTokenStepDefinitions
    {
        [Given(@"I create Auth Token using Post request")]
        public void GivenICreateAuthTokenUsingPostRequest()
        {
            var response = RestClientBaseRequests.CreateAuthToken();
            ScenarioContext.Current["response"] = response;
        }

        [Then(@"I verify Auth Token is created")]
        public void ThenIVerifyAuthTokenIsCreated()
        {
            var response = (AuthTokenResponseDTO)ScenarioContext.Current["response"];
            Assert.NotNull(response.token);
        }
    }
}
