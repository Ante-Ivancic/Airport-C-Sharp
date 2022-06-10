#pragma checksum "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2700b669d2d9a9ec77781b439c9d06b5ad6c31b"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
using FlightManagementBlazorServer.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/FlightList")]
    public partial class FlightList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Flights</h3>\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-success");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                        OpenAddFlightPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<span class=\"oi oi-plus\"></span>\n    Add Flight\n");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
 if(Flights == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<div>Loading...</div>");
#nullable restore
#line 16 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-responsive");
            __builder.AddMarkupContent(9, "<thead><tr><th>Number</th>\n                <th>Date</th>\n                <th>Time</th>\n                <th>Carrier</th>\n                <th>Airport to</th></tr></thead>\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 30 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
             foreach(var flight in Flights)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line 33 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(13, flight.Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 34 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(16, flight.FlightDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 35 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(19, flight.FlightTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 36 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(22, flight.Carrier?.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 37 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
__builder.AddContent(25, flight.AirportTo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/EditFlight/" + (
#nullable restore
#line 39 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                                              flight.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                                               () => DeleteFlight(flight.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-secondary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                                                  () => ArchiveFlight(flight.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "<span class=\"oi oi-transfer\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<FlightManagementBlazorServer.Pages.ConfirmationDialog>(44);
            __builder.AddAttribute(45, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 57 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                                          OnDeleteConfirmationSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(46, "Question", "Delete flight?");
            __builder.AddComponentReferenceCapture(47, (__value) => {
#nullable restore
#line 57 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                          DeleteConfirmationDialog = (FlightManagementBlazorServer.Pages.ConfirmationDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\n");
            __builder.OpenComponent<FlightManagementBlazorServer.Pages.ConfirmationDialog>(49);
            __builder.AddAttribute(50, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 58 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                                                                           OnArchiveConfirmationSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(51, "Question", "Archive flight?");
            __builder.AddComponentReferenceCapture(52, (__value) => {
#nullable restore
#line 58 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
                          ArchiveConfirmationDialog = (FlightManagementBlazorServer.Pages.ConfirmationDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
       
    private List<Flight> Flights;
    public ConfirmationDialog DeleteConfirmationDialog{ get; set; }
    public ConfirmationDialog ArchiveConfirmationDialog{ get; set; }
    public int SelectedFlightId{ get; set; }
    protected override async Task OnInitializedAsync()
    {
        Flights = await _flightService.GetFlights();
    }

    private void OpenAddFlightPage()
    {
        _navigationManager.NavigateTo("/AddFlight");
    }

    private async Task DeleteFlight(int flightId)
    {
        SelectedFlightId = flightId;
        DeleteConfirmationDialog.Show();
    }

    private async Task OnDeleteConfirmationSelected(bool isDeleteConfirmed)
    {
        if(isDeleteConfirmed)
        {
            await _flightService.DeleteFlight(SelectedFlightId);
            Flights = await _flightService.GetFlights();
        }
    }

    private async Task OnArchiveConfirmationSelected(bool isArchiveConfirmed)
    {
        if(isArchiveConfirmed)
        {
            await _flightService.ArchiveFlight(SelectedFlightId);
            Flights = await _flightService.GetFlights();
        }
    }

    private async Task ArchiveFlight(int flightId)
    {
        SelectedFlightId = flightId;
        ArchiveConfirmationDialog.Show();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
    }
}
#pragma warning restore 1591
