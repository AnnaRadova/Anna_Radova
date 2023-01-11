

namespace BL.ResponsesDTO
{
    public class CreateBookingResponseDTO
    {
        public int bookingid { get; set; }
        public Booking booking { get; set; }
    }

    public class Booking
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public BookingdatesResp bookingdates { get; set; }
        public string additionalneeds { get; set; }
    }

    public class BookingdatesResp
    {
        public string checkin { get; set; }
        public string checkout { get; set; }
    }
}
