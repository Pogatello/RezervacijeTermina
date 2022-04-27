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

		public bool ReservationMade { get; private set; }

		public DateTime? ReservationMadeAt { get; private set; }

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

		public ReservationPeriod(DateTime from, DateTime to, ReservationPeriodType reservationPeriodType, string userId, long reservationEventId)
		{
			From = from;
			To = to;
			ReservationPeriodType = reservationPeriodType;
			UserId = userId;
			ReservationEventId = reservationEventId;
		}

		#endregion

		#region Public Methods

		public void SetReservationPeriodType(ReservationPeriodType reservationPeriodType)
		{
			ReservationPeriodType = reservationPeriodType;
		}

		public void SetIsConfirmed(bool isConfirmed)
		{
			IsConfirmed = isConfirmed;
		}

		public void SetReservationMade(bool reservationMade)
		{
			ReservationMade = reservationMade;

			if (reservationMade)
			{
				ReservationMadeAt = DateTime.Now;
			}
			else
			{
				ReservationMadeAt = null;
			}
		}

		public bool IsForClosing()
		{
			return ReservationPeriodType == ReservationPeriodType.Closed;
		}

		public void SetUserId(string userId)
        {
			UserId = userId;
        }

		public void ResetUser()
		{
			//used for cancleing reservations
			User = null;
			UserId = null;
		}

		#endregion
	}
}