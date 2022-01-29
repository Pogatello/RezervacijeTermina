using System.Threading.Tasks;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationPeriod.Request;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationPeriod.Response;

namespace ZavrsniRad.RezervacijeTermina.Data.Services
{
	public interface IReservationPeriodService
	{
		Task<CreateReservationPeriodResponse> CreateReservationPeriodsAsync(CreateReservationPeriodRequest request);

		Task<UpdateReservationPeriodResponse> UpdateReservationPeriodsAsync(UpdateReservationPeriodRequest request);
	}
}