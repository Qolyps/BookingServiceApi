using BookingService.Domain.Contracts;
using BookingService.Domain.Models;

namespace BookingService.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<Booking> GetBookingAsync(Guid id)
        {
            return await _bookingRepository.GetBookingAsync(id);
        }

        public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
        {
            return await _bookingRepository.GetAllBookingsAsync();
        }

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            return await _bookingRepository.AddBookingAsync(booking);
        }

        public async Task<Booking> UpdateBookingAsync(Booking booking)
        {
            return await _bookingRepository.UpdateBookingAsync(booking);
        }

        public async Task DeleteBookingAsync(Guid id)
        {
            await _bookingRepository.DeleteBookingAsync(id);
        }
    }
}
