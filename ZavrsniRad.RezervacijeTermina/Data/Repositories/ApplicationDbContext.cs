using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZavrsniRad.RezervacijeTermina.Data.Models;

namespace ZavrsniRad.RezervacijeTermina.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		#region Properties

		public virtual DbSet<ReservationEvent> ReservationEvents { get; set; }

		public virtual DbSet<ReservationPeriod> ReservationPeriods { get; set; }

		#endregion

		#region Constructors

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		#endregion
	}
}