using BL.RequestsDTO;
using BL.ResponsesDTO;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace BL.BaseRequests
{
    public class RestClientBaseRequests
    {
        static RestClient restClient = new RestClient("https://restful-booker.herokuapp.com");
        static RestRequest restRequest;

        public static RestRequest CreateRestRequest(String recource, Method method)
        {
            if (restRequest == null)
            {
                return new RestRequest(recource, method);
            }
            else { return restRequest; }
        }

        public static AuthTokenResponseDTO CreateAuthToken()
        {
            restRequest = CreateRestRequest("/auth", Method.Post);
            restRequest.AddHeader("Content-Type", "application/json");

            var payLoad = CreatAuthTokenPayoad();
            restRequest.AddBody(payLoad);

            RestResponse response = restClient.Execute(restRequest);

            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<AuthTokenResponseDTO>(response.Content);
        }

        public static string CreatAuthTokenPayoad()
        {
            AuthTokenRequestDTO authTokenPayload = new AuthTokenRequestDTO();
            authTokenPayload.username = "admin";
            authTokenPayload.password = "password123";

            return JsonConvert.SerializeObject(authTokenPayload);
        }

        public static GetBookingResponseDTO GetBooking()
        {
            restRequest = CreateRestRequest("/booking/1", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);

            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<GetBookingResponseDTO>(response.Content);
        }

        public static CreateBookingResponseDTO CreateBooking()
        {
            restRequest = CreateRestRequest("/booking", Method.Post);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Accept", "application/json");

            var payload = CreateBookingPayload();
            restRequest.AddBody(payload);

            RestResponse response = restClient.Execute(restRequest);

            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<CreateBookingResponseDTO>(response.Content);
        }

        private static string CreateBookingPayload()
        {
            CreateBookingRequestDTO createBookingPayload = new CreateBookingRequestDTO();
            BookingdatesReq bookingDates = new BookingdatesReq();

            createBookingPayload.firstname = "Jim";
            createBookingPayload.lastname = "Brown";
            createBookingPayload.totalprice = 111;
            createBookingPayload.depositpaid = true;
            bookingDates.checkin = "2018-01-01";
            bookingDates.checkout = "2019-01-01";
            createBookingPayload.additionalneeds = "Breakfast";

            return JsonConvert.SerializeObject(createBookingPayload);
        }

        public static UpdateBookingResponseDTO UpdateBooking()
        {
            restRequest = CreateRestRequest("/booking/:id", Method.Put);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Accept", "application/json");

            var payLoad = CreateUpdateBookingPayLoad();
            restRequest.AddBody(payLoad);

            RestResponse response = restClient.Execute(restRequest);

            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<UpdateBookingResponseDTO>(response.Content);
        }

        public static string CreateUpdateBookingPayLoad()
        {
            UpdateBookingRequestDTO updateBookingPayload = new UpdateBookingRequestDTO();
            BookingdatesReq bookingDatesReq = new BookingdatesReq();

            updateBookingPayload.firstname = "James";
            updateBookingPayload.lastname = "Brown";
            updateBookingPayload.totalprice = 111;
            updateBookingPayload.depositpaid = true;
            bookingDatesReq.checkin = "2018-01-01";
            bookingDatesReq.checkout = "2019-01-01";
            updateBookingPayload.additionalneeds = "Breakfast";

            return JsonConvert.SerializeObject(updateBookingPayload);
        }

        public static CreateBookingResponseDTO DeleteBooking()
        {
            restRequest = CreateRestRequest("booking/1", Method.Delete);

            RestResponse response = restClient.Execute(restRequest);

            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<CreateBookingResponseDTO>(response.Content);

        }
    }
}
