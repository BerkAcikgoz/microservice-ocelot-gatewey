using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
            return this.reservationService.GetReservationByBkgNumber(Id);
        }
    }
}
