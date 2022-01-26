using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public class ReservationEvent
	{
		#region Properties

		[Key]
		public long Id { get; private set; }

		[NotMapped]
		public string EncodedId { get; private set; }

		[Required]
		public string Caption { get; private set; }

		[Required]
		public string Description { get; private set; }

		public string AdditionalContact { get; private set; }

		[Required]
		public DateTime ActiveFrom { get; private set; }

		public DateTime? ActiveTo { get; private set; }

		public bool CanUserMakeReservation { get; private set; }

		public bool IsReservationConfirmationNeeded { get; private set; }

		#endregion

		#region Navigation Properties

		public long AttachmentLogoId { get; private set; }

		public AttachmentLogo AttachmentLogo { get; private set; }

		public string UserId { get; private set; }

		public IdentityUser User { get; private set; }

		public IEnumerable<ReservationPeriod> ReservationPeriods { get; private set; }

		#endregion
	}
}