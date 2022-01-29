using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public interface IReservationRepository
	{
		Task<IEnumerable<ReservationEvent>> GetReservationEventsUserParticipatesInAsync(string userId);

		Task<IEnumerable<ReservationEvent>> GetReservationEventsCreatedByUserAsync(string userId);

		Task<ReservationEvent> GetReservationEventByIdAsync(long eventId);

		Task<ReservationEvent> CreateReservationEventAsync(ReservationEvent reservationEvent);

		Task<ReservationEvent> UpdateReservationEventAsync(ReservationEvent reservationEvent);

		Task<ReservationPeriod> CreateReservationPeriodAsync(ReservationPeriod reservationPeriod);

		Task<ReservationPeriod> UpdateReservationPeriodAsync(ReservationPeriod reservationPeriod);

		Task<ReservationPeriod> DeleteReservationPeriodAsync(ReservationPeriod reservationPeriod);
	}
}