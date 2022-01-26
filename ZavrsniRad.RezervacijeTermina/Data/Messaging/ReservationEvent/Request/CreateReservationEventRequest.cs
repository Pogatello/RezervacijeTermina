using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request
{
	public class CreateReservationEventRequest : RequestBase
	{
		public Models.ReservationEvent ReservationEvent { get; set; }
	}
}