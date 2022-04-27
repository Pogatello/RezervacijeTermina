// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZavrsniRad.RezervacijeTermina.Pages.Shared.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using ZavrsniRad.RezervacijeTermina;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\_Imports.razor"
using ZavrsniRad.RezervacijeTermina.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using ZavrsniRad.RezervacijeTermina.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using ZavrsniRad.RezervacijeTermina.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
using Data.Messaging.ReservationPeriod.Request;

#line default
#line hidden
#nullable disable
    public partial class CalendarScheduler : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 290 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\Shared\Components\CalendarScheduler.razor"
       
    [Parameter]
    public ReservationEvent ReservationEvent { get; set; }
    [Parameter]
    public string UserId { get; set; }
    [Parameter]
    public string UserName { get; set; }
    [Parameter]
    public bool IsOwner { get; set; }

    public bool IsLoading { get; set; }

    private IEnumerable<IGrouping<TimeSpan, ReservationPeriod>> ThisWeeksPeriods { get; set; }

    private Modal editModalRef;
    private ReservationPeriod ModalEditPeriod;

    private Modal createModalRef;
    private ReservationPeriod ModalCreatePeriod;

    private bool ShowErrorPopup;
    private string ErrorMessage;

    private DateTime FirstDay;
    private DateTime Today;
    private List<string> DaysOfTheWeek;
    private List<string> HoursOfTheDay;
    private int numberOfHoursInADay = 24;

    public string FirstCalendarCellLocation { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (ReservationEvent != null)
        {
            Today = DateTime.Now;
            FirstDay = GetModayAccordingTo(Today);
            DaysOfTheWeek = InitializeDaysOfTheWeek();
            HoursOfTheDay = InitializeHoursOfTheDay();
            ThisWeeksPeriods = GroupThisWeekPeriodsByHour();
            FirstCalendarCellLocation = ThisWeeksPeriods.Where(x => x.Any()).Min(x => x.Key).ToString(@"hh\:mm");
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await JS.InvokeVoidAsync("blazorHelpers.scrollToFragment", FirstCalendarCellLocation);
    }

    #region Initializing data

    private List<string> InitializeDaysOfTheWeek()
    {
        return new List<string>{
            "Ponedjeljak",
            "Utorak",
            "Srijeda",
            "Četvrtak",
            "Petak",
            "Subota",
            "Nedjelja"
          };
    }

    private List<string> InitializeHoursOfTheDay()
    {
        var hours = new List<string>();

        var day = DateTime.Now.Date;

        while (day.Date == DateTime.Now.Date)
        {
            hours.Add(day.ToString("HH:mm"));
            day = day.AddHours(1);
        }

        return hours;
    }
    IEnumerable<IGrouping<TimeSpan, ReservationPeriod>> GroupThisWeekPeriodsByHour()
    {
        var allPeriods = ReservationEvent.ReservationPeriods;

        var groupedPeriods = allPeriods
            .Where(x =>
                x.From.Date >= FirstDay.Date
                && x.From.Date < FirstDay.AddDays(7).Date
                )
            .OrderBy(x => x.From)
            .GroupBy(x => x.From.TimeOfDay)
            .ToList();

        return FillMissingTimeStamps(groupedPeriods);

    }

    IEnumerable<Grouping<TimeSpan, ReservationPeriod>> FillMissingTimeStamps(IEnumerable<IGrouping<TimeSpan, ReservationPeriod>> groupedPeriods)
    {
        var result = new List<Grouping<TimeSpan, ReservationPeriod>>();
        //used only for generating a nice time table;

        var startingTime = DateTime.Now.Date;
        var endTime = DateTime.Now.Date.AddDays(1);
        var stepInMinutes = ReservationEvent.ReservationDurationType == ReservationDurationType.HalfHour ? 30 : 60;

        while (startingTime.Date != endTime.Date)
        {
            var groupFound = groupedPeriods.SingleOrDefault(x => x.Key == startingTime.TimeOfDay);

            if (groupFound == null)
            {
                result.Add(new Grouping<TimeSpan, ReservationPeriod>(startingTime.TimeOfDay, new List<ReservationPeriod>()));
            }
            else
            {
                result.Add(new Grouping<TimeSpan, ReservationPeriod>(groupFound.Key, groupFound));

            }

            startingTime = startingTime.AddMinutes(stepInMinutes);
        }

        return result;
    }

    public class Grouping<TKey, TElement> : List<TElement>, IGrouping<TKey, TElement>
    {
        public Grouping(TKey key) : base() => Key = key;
        public Grouping(TKey key, int capacity) : base(capacity) => Key = key;
        public Grouping(TKey key, IEnumerable<TElement> collection)
            : base(collection) => Key = key;
        public TKey Key { get; }
    }

    private DateTime GetModayAccordingTo(DateTime now)
    {
        int delta = DayOfWeek.Monday - now.DayOfWeek;
        if (delta > 0)
            delta -= 7;
        DateTime monday = now.AddDays(delta);

        return monday;
    }

    #endregion

    #region Calendar Utility

    private void WeekBefore()
    {
        FirstDay = GetModayAccordingTo(FirstDay.AddDays(-7));
        ThisWeeksPeriods = GroupThisWeekPeriodsByHour();
        FirstCalendarCellLocation = ThisWeeksPeriods.Where(x => x.Any()).Min(x => x.Key).ToString(@"hh\:mm");

    }

    private void WeekAfter()
    {
        FirstDay = GetModayAccordingTo(FirstDay.AddDays(7));
        ThisWeeksPeriods = GroupThisWeekPeriodsByHour();
        FirstCalendarCellLocation = ThisWeeksPeriods.Where(x => x.Any()).Min(x => x.Key).ToString(@"hh\:mm");
    }

    private ReservationPeriod GetReservationPeriod(IEnumerable<ReservationPeriod> input, int index)
    {
        return input.ToList().FirstOrDefault(x => GetDaysIndex(x.From) == index);
    }

    private int GetDaysIndex(DateTime day)
    {
        var index = (int)day.DayOfWeek - 1;

        return index < 0 ? 7 : index;
    }

    #endregion

    #region Edit Modal

    private void OpenPopupForAdministration(ReservationPeriod reservationPeriod)
    {
        ModalEditPeriod = reservationPeriod;

        ShowEditModal();
    }

    private void ShowEditModal()
    {
        editModalRef.Show();
    }

    private void HideEditModal()
    {
        editModalRef.Hide();
    }

    void OnSelectedValueChangedReservationPeriodType(int value)
    {
        ModalEditPeriod.SetReservationPeriodType((ReservationPeriodType)value);
    }

    void OnIsConfirmedChanged(bool value)
    {
        ModalEditPeriod.SetIsConfirmed(value);
    }

    async Task UpdateReservation()
    {
        var response = await ReservationPeriodService.UpdateReservationPeriodsAsync
            (
                new UpdateReservationPeriodRequest
                {
                    ReservationPeriod = ModalEditPeriod,
                    UserId = IsOwner ? null : UserId
                }
            );

        if (response.Success)
        {
            HideEditModal();
            this.StateHasChanged();
        }
        else
        {
            ShowPopupWithErrorMessage(response.ErrorMessage);
        }

    }

    async Task ConfirmReservation()
    {
        if (ModalEditPeriod.IsConfirmed == false)
        {
            //cancle reservation
            ModalEditPeriod.ResetUser();
            ModalEditPeriod.SetReservationPeriodType(ReservationPeriodType.Free);
        }

        ModalEditPeriod.SetReservationPeriodType(ReservationPeriodType.Reserved);

        var response = await ReservationPeriodService.UpdateReservationPeriodsAsync
        (
            new UpdateReservationPeriodRequest
            {
                ReservationPeriod = ModalEditPeriod,
                UserId = IsOwner ? null : UserId
            }
        );

        if (response.Success)
        {
            HideEditModal();
        }
        else
        {
            ShowPopupWithErrorMessage(response.ErrorMessage);
        }

    }

    async Task UserMadeReservation()
    {
        ModalEditPeriod.SetIsConfirmed(ReservationEvent.IsReservationConfirmationNeeded ? false : true);
        ModalEditPeriod.SetReservationMade(true);

        var response = await ReservationPeriodService.UpdateReservationPeriodsAsync
        (
            new UpdateReservationPeriodRequest
            {
                ReservationPeriod = ModalEditPeriod,
                UserId = UserId
            }
        );

        if (response.Success)
        {
            HideEditModal();
        }
        else
        {
            ShowPopupWithErrorMessage(response.ErrorMessage);
        }

    }

    #endregion

    #region Create Modal

    void OpenPopupForNewPeriod(TimeSpan time, int dayOfWeek)
    {
        var date = FirstDay.AddDays(dayOfWeek);
        var dateTime = new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds);
        var stepInMinutes = ReservationEvent.ReservationDurationType == ReservationDurationType.HalfHour ? 30 : 60;

        ModalCreatePeriod = new ReservationPeriod
            (
            dateTime,
            dateTime.AddMinutes(stepInMinutes),
            ReservationPeriodType.Closed,
            null,
            ReservationEvent.Id
            );

        ShowCreateModal();
    }

    private void ShowCreateModal()
    {
        createModalRef.Show();
    }

    private void HideCreateModal()
    {
        createModalRef.Hide();
    }

    async Task CreateReservation()
    {
        var response = await ReservationPeriodService.CreateReservationPeriodsAsync
            (
                new CreateReservationPeriodRequest
                {
                    ReservationPeriod = ModalCreatePeriod,
                    UserId = IsOwner ? null : UserId
                }
            );

        if (response.Success)
        {
            HideCreateModal();
        }
        else
        {
            ShowPopupWithErrorMessage(response.ErrorMessage);
        }

    }

    void OnSelectedValueChangedReservationPeriodTypeForCreate(int value)
    {
        ModalCreatePeriod.SetReservationPeriodType((ReservationPeriodType)value);
    }

    #endregion

    #region Error Popup

    void ShowPopupWithErrorMessage(string message)
    {
        ErrorMessage = message;
        ShowErrorPopup = true;
    }

    void ClosePopup()
    {
        ShowErrorPopup = false;
    }

    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservationPeriodService ReservationPeriodService { get; set; }
    }
}
#pragma warning restore 1591
