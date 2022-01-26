using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Response
{
	public class GetReservationEventResponse : ResponseBase
	{
		public Models.ReservationEvent ReservationEvent { get; set; }
	}
}