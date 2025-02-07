using BookingService.Domain.Models;

namespace BookingService.Domain.Contracts
{
    public interface IBookingService
    {
        Task<Booking> GetBookingAsync(Guid id);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<Booking> CreateBookingAsync(Booking booking);
        Task<Booking> UpdateBookingAsync(Booking booking);
        Task DeleteBookingAsync(Guid id);
    }
}
