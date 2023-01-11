

namespace BL.ResponsesDTO
{
    public class UpdateBookingResponseDTO
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public BookingdatesRes bookingdates { get; set; }
        public string additionalneeds { get; set; }
    }

    public class BookingdatesRes
    {
        public string checkin { get; set; }
        public string checkout { get; set; }
    }
}
