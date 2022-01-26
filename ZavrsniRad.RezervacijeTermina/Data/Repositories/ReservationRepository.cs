using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZavrsniRad.RezervacijeTermina.Data.Models;

namespace ZavrsniRad.RezervacijeTermina.Data.Repositories
{
	public class ReservationRepository : IReservationRepository
	{
		#region Fields

		private readonly ApplicationDbContext _dbContext;

		#endregion

		#region Constructors

		public ReservationRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#endregion

		#region Public Methods

		public async Task<IEnumerable<ReservationEvent>> GetReservationEventsUserParticipatesInAsync(string userId)
		{
			return await _dbContext.ReservationEvents
				.Where(res => res.ReservationPeriods
				.Any(rp => rp.User.Id == userId))
				.ToListAsync();
		}

		public async Task<IEnumerable<ReservationEvent>> GetReservationEventsCreatedByUserAsync(string userId)
		{
			return await _dbContext.ReservationEvents
				.Where(res => res.User.Id == userId)
				.ToListAsync();
		}

		public async Task<ReservationEvent> GetReservationEventByIdAsync(long eventId)
		{
			return await _dbContext.ReservationEvents
				.SingleOrDefaultAsync(res => res.Id == eventId);
		}

		public async Task<ReservationEvent> CreateReservationEventAsync(ReservationEvent reservationEvent)
		{
			_dbContext.ReservationEvents.Add(reservationEvent);
			await _dbContext.SaveChangesAsync();

			return reservationEvent;
		}

		public async Task<ReservationEvent> UpdateReservationEventAsync(ReservationEvent reservationEvent)
		{
			_dbContext.ReservationEvents.Update(reservationEvent);
			await _dbContext.SaveChangesAsync();

			return reservationEvent;
		}

		#endregion
	}
}