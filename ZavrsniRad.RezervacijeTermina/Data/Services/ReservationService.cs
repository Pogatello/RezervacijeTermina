using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

		private readonly int RESERVATIONS_DAYS_AHEAD = 30;

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
				var reservationPeriods = MakeReservationPeriodsForTimeAhead(request.DayWithWorkingTimes, request.ReservationEvent);
				request.ReservationEvent.SetReservationPeriods(reservationPeriods);
				request.ReservationEvent.SetUserId(request.UserId);

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

		#region Private Methods

		private IEnumerable<ReservationPeriod> MakeReservationPeriodsForTimeAhead(IEnumerable<DayWithWorkingTime> daysWithTimes, ReservationEvent reservationEvent)
		{
			var reservationPeriods = new List<ReservationPeriod>();

			var startDate = reservationEvent.ActiveFrom.Date;
			var endDate = startDate.AddDays(RESERVATIONS_DAYS_AHEAD);

			while (startDate.Date != endDate.Date)
			{
				var correctDayWithWorkingHours = daysWithTimes.ToList().FirstOrDefault(x => x.DayOfWeek == startDate.DayOfWeek);

				reservationPeriods.AddRange(CreatePeriodsForCompleteDay(startDate, correctDayWithWorkingHours, reservationEvent));
				startDate = startDate.AddDays(1);
			}

			return reservationPeriods;
		}

		private IEnumerable<ReservationPeriod> CreatePeriodsForCompleteDay(DateTime date, DayWithWorkingTime dayWithWorkingTime, ReservationEvent reservationEvent)
		{
			var reservationPeriods = new List<ReservationPeriod>();
			var periodStepInMinutes = reservationEvent.ReservationDurationType == ReservationDurationType.HalfHour ? 30 : 60;
			var endDate = date.AddDays(1);

			while (date.Date != endDate.Date)
			{
				reservationPeriods.Add
					(
					new ReservationPeriod
					(
						date,
						date.AddMinutes(periodStepInMinutes),
						reservationEvent.IsReservationConfirmationNeeded ? false : true,
						CheckReservationPeriodPerWorkingHours(date, dayWithWorkingTime),
						reservationEvent.UserId,
						reservationEvent.Id
						)
					);

				date = date.AddMinutes(periodStepInMinutes);
			}

			return reservationPeriods;
		}

		private ReservationPeriodType CheckReservationPeriodPerWorkingHours(DateTime date, DayWithWorkingTime dayWithWorkingTime)
		{
			if (date.TimeOfDay >= dayWithWorkingTime.WorkingFrom && date.TimeOfDay <= dayWithWorkingTime.WorkingTo)
			{
				return ReservationPeriodType.Free;
			}

			return ReservationPeriodType.Closed;
		}

		#endregion
	}
}