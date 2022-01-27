using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZavrsniRad.RezervacijeTermina.Data.Models
{
	[NotMapped]
	public class DayWithWorkingTime
	{
		public string Day { get; set; }

		public DayOfWeek DayOfWeek { get; set; }

		public TimeSpan? WorkingFrom { get; set; }

		public TimeSpan? WorkingTo { get; set; }
	}
}