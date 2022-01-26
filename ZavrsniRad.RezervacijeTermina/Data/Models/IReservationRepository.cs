using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public interface IReservationRepository
	{
		public Task<IEnumerable<ReservationEvent>> GetReservationEventsUserParticipatesInAsync(string userId);

		public Task<IEnumerable<ReservationEvent>> GetReservationEventsCreatedByUserAsync(string userId);

		public Task<ReservationEvent> GetReservationEventByIdAsync(long eventId);

		public Task<ReservationEvent> CreateReservationEventAsync(ReservationEvent reservationEvent);

		public Task<ReservationEvent> UpdateReservationEventAsync(ReservationEvent reservationEvent);
	}
}