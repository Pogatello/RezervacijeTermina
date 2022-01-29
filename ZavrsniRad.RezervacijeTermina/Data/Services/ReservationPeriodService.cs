using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using ZavrsniRad.RezervacijeTermina.Data.Infrastructure;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationPeriod.Request;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationPeriod.Response;
using ZavrsniRad.RezervacijeTermina.Data.Models;

namespace ZavrsniRad.RezervacijeTermina.Data.Services
{
	public class ReservationPeriodService : IReservationPeriodService
	{
		#region Fields

		private readonly IReservationRepository _reservationRepository;

		private readonly ILogger _logger;

		#endregion

		#region Constructors

		public ReservationPeriodService
			(
				IReservationRepository reservationRepository,
				ILogger<ReservationService> logger,
				IEncryptionService encryptionService
			)
		{
			_reservationRepository = reservationRepository;
			_logger = logger;
		}

		#endregion

		#region Public Methods

		public async Task<CreateReservationPeriodResponse> CreateReservationPeriodsAsync(CreateReservationPeriodRequest request)
		{
			var response = new CreateReservationPeriodResponse();
			try
			{
				await _reservationRepository.CreateReservationPeriodAsync(request.ReservationPeriod);

				response.Success = true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				response.ErrorMessage = ErrorMessages.DefaultError;
			}

			return response;
		}

		public async Task<UpdateReservationPeriodResponse> UpdateReservationPeriodsAsync(UpdateReservationPeriodRequest request)
		{
			var response = new UpdateReservationPeriodResponse();
			try
			{
				if (request.ReservationPeriod.IsForClosing())
				{
					await _reservationRepository.DeleteReservationPeriodAsync(request.ReservationPeriod);
				}
				else
				{
					await _reservationRepository.UpdateReservationPeriodAsync(request.ReservationPeriod);
				}

				response.Success = true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				response.ErrorMessage = ErrorMessages.DefaultError;
			}

			return response;
		}

		#endregion
	}
}