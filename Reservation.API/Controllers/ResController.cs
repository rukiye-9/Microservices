using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;

namespace Reservation.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ResController : ControllerBase
{
    private readonly IReservationService reservationService;

    public ResController(IReservationService reservationService)
    {
        this.reservationService = reservationService;
    }

    [HttpGet("{id}")]
    public ReservationDTO Get(int id)
    {
        return reservationService.GetResByBkgNumber(id);
    }
}