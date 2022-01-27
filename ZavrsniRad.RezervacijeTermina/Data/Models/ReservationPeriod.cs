using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	public class ReservationPeriod
	{
		#region Properties

		[Key]
		public long Id { get; private set; }

		[Required]
		public DateTime From { get; private set; }

		[Required]
		public DateTime To { get; private set; }

		public bool IsConfirmed { get; private set; }

		public ReservationPeriodType ReservationPeriodType { get; private set; }

		#endregion

		#region Navigation Properties

		public string UserId { get; private set; }

		public IdentityUser User { get; private set; }

		public long ReservationEventId { get; private set; }

		public ReservationEvent ReservationEvent { get; private set; }

		#endregion

		#region Constructors

		public ReservationPeriod()
		{
		}

		public ReservationPeriod(DateTime from, DateTime to, bool isConfirmed, ReservationPeriodType reservationPeriodType, string userId, long reservationEventId)
		{
			From = from;
			To = to;
			IsConfirmed = isConfirmed;
			ReservationPeriodType = reservationPeriodType;
			UserId = userId;
			ReservationEventId = reservationEventId;
		}

		#endregion
	}
}