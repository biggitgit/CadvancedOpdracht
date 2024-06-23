using CadvancedOpdracht.Dtos.Dto;
using System.Threading.Tasks;

namespace CadvancedOpdracht.Services.Reservation
{
    public interface IReservationService
    {
        Task<ReservationResponseDto> CreateReservationAsync(ReservationRequestDto requestDto);
    }
}
