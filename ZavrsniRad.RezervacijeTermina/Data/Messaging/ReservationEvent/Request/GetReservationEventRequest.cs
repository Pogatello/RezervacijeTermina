using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request
{
	public class GetReservationEventRequest : RequestBase
	{
		public string Id { get; set; }
	}
}