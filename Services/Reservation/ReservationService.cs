using CadvancedOpdracht.Data;
using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CadvancedOpdracht.Services.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly CadvancedOpdrachtContext _context;
        private readonly IFullRepository _repository;

        public ReservationService(CadvancedOpdrachtContext context, IFullRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public async Task<ReservationResponseDto> CreateReservationAsync(ReservationRequestDto requestDto)
        {
            var customer = await _repository.GetCustomerAsync(requestDto.Email, requestDto.FirstName, requestDto.LastName, CancellationToken.None);
            var location = await _context.Locations.FindAsync(requestDto.LocationId);
            if (location == null)
            {
                return null;
            }
            var amountOfDaysDays = (requestDto.EndDate - requestDto.StartDate).Days;
            float pricePerDay = location.PricePerDay;
            float discount = requestDto.Discount ?? 0;
            float priceForAllDays = (pricePerDay * amountOfDaysDays) - discount;

            var reservation = new Models.Reservation
            {
                StartDate = requestDto.StartDate,
                EndDate = requestDto.EndDate,
                LocationId = requestDto.LocationId,
                Discount = discount,
                CustomerId = customer.Id
            };

            await _repository.AddReservationAsync(reservation, CancellationToken.None);

            return new ReservationResponseDto
            {
                LocationName = location.Title,
                CustomerName = $"{customer.FirstName} {customer.LastName}",
                Price = priceForAllDays,
                Discount = reservation.Discount
            };
        }

    }
}
