using BookingService.Domain.Models;

namespace BookingService.Domain.Contracts
{
    public interface IBookingRepository
    {
        Task<Booking> GetBookingAsync(Guid id);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<Booking> AddBookingAsync(Booking booking);
        Task<Booking> UpdateBookingAsync(Booking booking);
        Task DeleteBookingAsync(Guid id);
    }
}
