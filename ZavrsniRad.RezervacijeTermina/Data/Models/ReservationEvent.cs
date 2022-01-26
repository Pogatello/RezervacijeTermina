using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public class ReservationEvent
	{
		#region Properties

		public long Id { get; private set; }

		public string Caption { get; private set; }

		public string Description { get; private set; }

		public string AdditionalContact { get; private set; }

		public DateTime ActiveFrom { get; private set; }

		public DateTime? ActiveTo { get; private set; }

		public bool CanUserMakeReservation { get; private set; }

		public bool IsReservationConfirmationNeeded { get; private set; }

		public IEnumerable<ReservationPeriod> ReservationPeriods { get; private set; }

		#endregion

		#region Navigation Properties

		public AttachmentLogo Logo { get; private set; }

		public IdentityUser User { get; private set; }

		#endregion
	}
}