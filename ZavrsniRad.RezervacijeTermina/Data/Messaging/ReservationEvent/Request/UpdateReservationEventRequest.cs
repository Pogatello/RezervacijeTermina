using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request
{
	public class UpdateReservationEventRequest : RequestBase
	{
		public Models.ReservationEvent ReservationEvent { get; set; }
	}
}