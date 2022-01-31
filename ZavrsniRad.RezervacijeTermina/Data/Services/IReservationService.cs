using System.Threading.Tasks;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Response;

namespace ZavrsniRad.RezervacijeTermina.Data.Services
{
	public interface IReservationService
	{
		public Task<GetReservationEventsResponse> GetReservationEventsUserParticipatesInAsync(GetReservationEventsRequest request);

		public Task<GetAllReservationEventsResponse> GetAllReservationEventsWithoutUserAsync(GetAllReservationEventsRequest request);

		public Task<GetReservationEventsResponse> GetReservationEventsCreatedByUserAsync(GetUsersReservationEventsRequest request);

		public Task<GetReservationEventResponse> GetReservationEventByIdAsync(GetReservationEventRequest request);

		public Task<CreateReservationEventResponse> CreateReservationEventAsync(CreateReservationEventRequest request);

		public Task<UpdateReservationEventResponse> UpdateReservationEventAsync(UpdateReservationEventRequest request);
	}
}