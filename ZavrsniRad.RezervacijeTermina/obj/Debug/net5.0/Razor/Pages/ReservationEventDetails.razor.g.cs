#pragma checksum "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fabea75e490b0826f881fca06c376b189f952ab"
// <auto-generated/>
#pragma warning disable 1591
namespace ZavrsniRad.RezervacijeTermina.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
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
#line 3 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using ZavrsniRad.RezervacijeTermina.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using ZavrsniRad.RezervacijeTermina.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using ZavrsniRad.RezervacijeTermina.Data.Messaging.ReservationEvent.Request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using ZavrsniRad.RezervacijeTermina.Pages.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
using Pages.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{id}")]
    public partial class ReservationEventDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 17 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
 if (IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 20 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.Card>(1);
            __builder.AddAttribute(2, "Margin", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 23 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                  Margin.Is4.OnY

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.CardBody>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.CardTitle>(6);
                    __builder3.AddAttribute(7, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                             5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 25 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder4.AddContent(9, ReservationEvent.Caption);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n            <br>\r\n            ");
                    __builder3.OpenComponent<Blazorise.CardText>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Container>(13);
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Blazorise.Row>(15);
                            __builder5.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<Blazorise.Column>(17);
                                __builder6.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<Blazorise.Row>(19);
                                    __builder7.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 31 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder8.AddContent(21, ReservationEvent.Description);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(22, "\r\n                            <br>\r\n                            ");
                                    __builder7.OpenComponent<Blazorise.Row>(23);
                                    __builder7.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(25, "Kontakt: ");
#nullable restore
#line 33 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder8.AddContent(26, ReservationEvent?.User?.UserName);

#line default
#line hidden
#nullable disable
                                        __builder8.AddContent(27, " (");
#nullable restore
#line 33 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder8.AddContent(28, ReservationEvent.AdditionalContact);

#line default
#line hidden
#nullable disable
                                        __builder8.AddContent(29, ")");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(30, "\r\n                            ");
                                    __builder7.OpenComponent<Blazorise.Row>(31);
                                    __builder7.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(33, "\r\n                                Aktivno: Od ");
#nullable restore
#line 35 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder8.AddContent(34, ReservationEvent.ActiveFrom.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                                                 if (ReservationEvent.ActiveTo != null)
                                {

#line default
#line hidden
#nullable disable
                                        __builder8.OpenElement(35, "span");
                                        __builder8.AddContent(36, " Do ");
#nullable restore
#line 36 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder8.AddContent(37, ReservationEvent.ActiveTo.Value.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                                        __builder8.CloseElement();
#nullable restore
#line 36 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                                                          }

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(38, "\r\n                            <br>\r\n                            <br>");
#nullable restore
#line 40 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                             if (ReservationEvent.CanUserMakeReservation)
                            {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<Blazorise.Row>(39);
                                    __builder7.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(41, "<i class=\"fas fa-exclamation-triangle\"></i> Korisnik može sam napraviti rezervaciju u nekom od slobodnih termina");
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 43 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                 if (ReservationEvent.IsReservationConfirmationNeeded)
                                {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<Blazorise.Row>(42);
                                    __builder7.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(44, "<i class=\"fas fa-exclamation-triangle\"></i> Vlasnik termina mora potvrditi rezervaciju.");
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 46 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                 
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<Blazorise.Row>(45);
                                    __builder7.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(47, "<i class=\"fas fa-exclamation-triangle\"></i> Potrebno je kontaktirati vlasnika za dogovor rezervacije");
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 51 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                            }

#line default
#line hidden
#nullable disable
                                }
                                ));
                                __builder6.CloseComponent();
#nullable restore
#line 53 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                         if (ReservationEvent.AttachmentLogo != null)
                        {

#line default
#line hidden
#nullable disable
                                __builder6.OpenComponent<Blazorise.Column>(48);
                                __builder6.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenElement(50, "img");
                                    __builder7.AddAttribute(51, "src", "data:image/png;base64," + (
#nullable restore
#line 56 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                 ReservationEvent.AttachmentLogo.Content

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(52, "class", "centerI");
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
#nullable restore
#line 58 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                        }

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                <br>\r\n                ");
                        __builder4.OpenComponent<ZavrsniRad.RezervacijeTermina.Pages.Shared.Components.CalendarScheduler>(54);
                        __builder4.AddAttribute(55, "ReservationEvent", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ZavrsniRad.RezervacijeTermina.Data.Models.ReservationEvent>(
#nullable restore
#line 62 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                     ReservationEvent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "IsOwner", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                               IsOwner

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "UserId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                                               UserId

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "UserName", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                                                                UserName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 67 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
     if (showPopup)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal fade show d-block");
            __builder.AddAttribute(61, "id", "exampleModal");
            __builder.AddAttribute(62, "tabindex", "-1");
            __builder.AddAttribute(63, "role", "dialog");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-dialog");
            __builder.AddAttribute(66, "role", "document");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-content");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal-header");
            __builder.AddMarkupContent(71, "<h5 class=\"modal-title\" id=\"titleLabel\">Response</h5>\r\n                        ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "class", "close");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                       ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "data-dismiss", "modal");
            __builder.AddAttribute(77, "aria-label", "Close");
            __builder.AddMarkupContent(78, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "modal-body");
#nullable restore
#line 79 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
__builder.AddContent(82, ErrorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-footer");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "type", "button");
            __builder.AddAttribute(88, "class", "btn btn-secondary");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
                                                                                   ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "data-dismiss", "modal");
            __builder.AddContent(91, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
     

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(92, @"<style>

    i {
        margin-right: 5px;
        line-height: 1.5 !important;
    }

    .imageContainer {
        height: 200px;
    }

    .centerI {
      display: block;
      margin-left: auto;
      margin-right: auto;
      max-height:250px;
    }

        .imageContainer img {
            max-width: 100%;
            max-height: 100%;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\Marko\source\repos\ZavrsniRad.RezervacijeTermina\ZavrsniRad.RezervacijeTermina\Pages\ReservationEventDetails.razor"
       
    [Parameter]
    public string Id { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> AuthenticationStateTask { get; set; }

    ReservationEvent ReservationEvent;
    string UserId;
    string UserName;

    bool IsOwner;
    string ErrorMessage;
    bool showPopup;
    bool IsLoading = true;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateTask;
        UserId = authState.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
        UserName = authState.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

        var response = await ReservationService.GetReservationEventByIdAsync
            (
            new GetReservationEventRequest
            {
                Id = Convert.ToInt64(Id),
                UserId = UserId
            }
            );

        if (response.Success)
        {
            ReservationEvent = response.ReservationEvent;

            if (ReservationEvent != null)
            {
                if (UserId == ReservationEvent.UserId)
                {
                    IsOwner = true;
                }

                IsLoading = false;
            }
        }
        else
        {
            ShowPopupWithErrorMessage(response.ErrorMessage);
        }
    }

    void ShowPopupWithErrorMessage(string message)
    {
        ErrorMessage = message;
        showPopup = true;
    }

    void ClosePopup()
    {
        showPopup = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservationService ReservationService { get; set; }
    }
}
#pragma warning restore 1591
