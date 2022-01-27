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

		[Required]
		public ReservationDurationType ReservationDurationType { get; private set; }

		#endregion

		#region Navigation Properties

		public long AttachmentLogoId { get; private set; }

		public AttachmentLogo AttachmentLogo { get; private set; }

		public string UserId { get; private set; }

		public IdentityUser User { get; private set; }

		public IEnumerable<ReservationPeriod> ReservationPeriods { get; private set; }

		#endregion

		#region Public Methods

		public void SetEncodedId(string encodedId)
		{
			EncodedId = encodedId;
		}

		public void SetCaption(string caption)
		{
			Caption = caption;
		}

		public void SetDescription(string description)
		{
			Description = description;
		}

		public void SetAdditionalContact(string additionalContact)
		{
			AdditionalContact = additionalContact;
		}

		public void SetActiveFrom(DateTime activeFrom)
		{
			ActiveFrom = activeFrom;
		}

		public void SetActiveTo(DateTime? activeTo)
		{
			ActiveTo = activeTo;
		}

		public void SetCanUserMakeReservation(bool canUserMakeReservation)
		{
			CanUserMakeReservation = canUserMakeReservation;
		}

		public void SetIsReservationConfirmationNeeded(bool isReservationConfirmationNeeded)
		{
			IsReservationConfirmationNeeded = isReservationConfirmationNeeded;
		}

		public void SetAttachmentLogo(AttachmentLogo attachmentLogo)
		{
			AttachmentLogo = attachmentLogo;
		}

		public void SetReservationDurationType(ReservationDurationType type)
		{
			ReservationDurationType = type;
		}

		public void SetReservationPeriods(IEnumerable<ReservationPeriod> periods)
		{
			ReservationPeriods = periods;
		}

		#endregion
	}
}