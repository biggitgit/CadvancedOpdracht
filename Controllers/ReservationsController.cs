using Asp.Versioning;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Dtos.Dto;
using CadvancedOpdracht.Models;
using CadvancedOpdracht.Services.Reservation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadvancedOpdracht.Controllers
{
    [ApiVersion(1.0)]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        // POST: api/Reservations
        [HttpPost]
        public async Task<ActionResult<ReservationResponseDto>> CreateReservation(ReservationRequestDto requestDto)
        {
            var responseDto = await _reservationService.CreateReservationAsync(requestDto);

            if (responseDto == null)
            {
                return BadRequest("Reservation could not be created.");
            }

            return Ok(responseDto);
        }
    }
}
