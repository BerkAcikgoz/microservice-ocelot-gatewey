using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO
            {
                Id = (new Random()).Next(199),
                Amount = 1000,
                BkgDate = DateTime.Now,
                BkgNumber = BkgNumber,
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37)
            };
        }
    }
}
