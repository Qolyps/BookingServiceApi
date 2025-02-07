namespace BookingService.Domain.Models
{
    public class Booking
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public string CustomerName { get; set; } = string.Empty; 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public bool IsConfirmed { get; set; } = false; 
    }
}
