using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationPeriod.Request
{
	public class CreateReservationPeriodRequest : RequestBase
	{
		public Models.ReservationPeriod ReservationPeriod { get; set; }
	}
}