using ZavrsniRad.RezervacijeTermina.Data.Messaging.Common;

namespace ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationPeriod.Request
{
	public class UpdateReservationPeriodRequest : RequestBase
	{
		public Models.ReservationPeriod ReservationPeriod { get; set; }
	}
}