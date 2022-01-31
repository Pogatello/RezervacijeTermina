using System.Collections.Generic;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Response
{
	public class GetAllReservationEventsResponse : ResponseBase
	{
		public IEnumerable<Models.ReservationEvent> ReservationEvents { get; set; }
	}
}