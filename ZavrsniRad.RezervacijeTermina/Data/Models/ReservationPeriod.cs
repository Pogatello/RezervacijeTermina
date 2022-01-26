using Microsoft.AspNetCore.Identity;
using System;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public class ReservationPeriod
	{
		#region Properties

		public long Id { get; private set; }

		public DateTime From { get; private set; }

		public DateTime To { get; private set; }

		public bool IsConfirmed { get; private set; }

		public ReservationPeriodType ReservationPeriodType { get; private set; }

		#endregion

		#region Navigation Properties

		public IdentityUser User { get; set; }

		#endregion
	}
}