using System.Collections.Generic;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;
using ZavrsniRad.RezervacijeTermina.Data.Models;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request
{
	public class CreateReservationEventRequest : RequestBase
	{
		public Models.ReservationEvent ReservationEvent { get; set; }

		public IEnumerable<DayWithWorkingTime> DayWithWorkingTimes { get; set; }
	}
}