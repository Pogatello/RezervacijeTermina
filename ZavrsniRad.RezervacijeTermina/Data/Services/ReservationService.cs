using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using ZavrsniRad.RezervacijeTermina.Data.Infrastructure;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request;
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Response;
using ZavrsniRad.RezervacijeTermina.Data.Models;

namespace ZavrsniRad.RezervacijeTermina.Data.Services
{
	public class ReservationService : IReservationService
	{
		#region Fields

		private readonly IReservationRepository _reservationRepository;

		private readonly ILogger _logger;

		private readonly IEncryptionService _encryptionService;

		#endregion

		#region Constructors

		public ReservationService
			(
				IReservationRepository reservationRepository,
				ILogger<ReservationService> logger,
				IEncryptionService encryptionService
			)
		{
			_reservationRepository = reservationRepository;
			_logger = logger;
			_encryptionService = encryptionService;
		}

		#endregion

		#region Public Methods

		public async Task<GetReservationEventsResponse> GetReservationEventsUserParticipatesInAsync(GetReservationEventsRequest request)
		{
			var response = new GetReservationEventsResponse();

			try
			{
				var reservationEvents = await _reservationRepository.GetReservationEventsUserParticipatesInAsync(request.UserId);

				response.ReservationEvents = reservationEvents;
				response.Success = true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				response.ErrorMessage = ErrorMessages.DefaultError;
			}

			return response;
		}

		public async Task<GetReservationEventsResponse> GetReservationEventsCreatedByUserAsync(GetUsersReservationEventsRequest request)
		{
			var response = new GetReservationEventsResponse();

			try
			{
				var reservationEvents = await _reservationRepository.GetReservationEventsCreatedByUserAsync(request.UserId);

				response.ReservationEvents = reservationEvents;
				response.Success = true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				response.ErrorMessage = ErrorMessages.DefaultError;
			}

			return response;
		}

		public async Task<GetReservationEventResponse> GetReservationEventByIdAsync(GetReservationEventRequest request)
		{
			var response = new GetReservationEventResponse();

			try
			{
				var decryptedId = _encryptionService.UrlDecodeAndDecrypt(request.Id);

				var reservationEvent = await _reservationRepository.GetReservationEventByIdAsync(Convert.ToInt64(decryptedId));

				response.ReservationEvent = reservationEvent;
				response.Success = true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				response.ErrorMessage = ErrorMessages.DefaultError;
			}

			return response;
		}

		public async Task<CreateReservationEventResponse> CreateReservationEventAsync(CreateReservationEventRequest request)
		{
			var response = new CreateReservationEventResponse();

			try
			{
				await _reservationRepository.CreateReservationEventAsync(request.ReservationEvent);

				response.Success = true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				response.ErrorMessage = ErrorMessages.DefaultError;
			}

			return response;
		}

		public async Task<UpdateReservationEventResponse> UpdateReservationEventAsync(UpdateReservationEventRequest request)
		{
			var response = new UpdateReservationEventResponse();

			try
			{
				await _reservationRepository.UpdateReservationEventAsync(request.ReservationEvent);

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