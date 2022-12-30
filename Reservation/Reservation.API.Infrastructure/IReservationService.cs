namespace Reservation.API.Infrastructure;

public class IReservationService
{
    public ReservationDTO GetResByBkgNumber(int bkgNumber)
    {
        return new ReservationDTO
        {
            ID= (new Random()).Next(100),
            Amount= (new Random()).Next(100),
            BkgDate=DateTime.Now,
            CheckinDate=DateTime.Now,
            CheckoutDate=DateTime.Now,
            BkgNumber=bkgNumber,
        };
    }
}