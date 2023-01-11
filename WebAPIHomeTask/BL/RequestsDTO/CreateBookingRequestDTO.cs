

namespace BL.RequestsDTO
{
    public class CreateBookingRequestDTO
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public BookingdatesReq bookingdates { get; set; }
        public string additionalneeds { get; set; }
    }

    public class BookingdatesReq
    {
        public string checkin { get; set; }
        public string checkout { get; set; }
    }
}
