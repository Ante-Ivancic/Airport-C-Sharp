#pragma checksum "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a89a8533cb10f4a519d047df95e8f3708cf1fe0"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddCarrier")]
    public partial class AddCarrier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Carrier</h3>");
#nullable restore
#line 7 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
 if(Carrier == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading..</p>");
#nullable restore
#line 10 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
                      Carrier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
                                               AddCarrierAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<FlightManagementBlazorServer.Pages.CarrierFields>(6);
                __builder2.AddAttribute(7, "Carrier", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DomainModel.Models.Carrier>(
#nullable restore
#line 15 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
                                 Carrier

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.AddMarkupContent(9, "<button type=\"submit\" class=\"btn btn-success\"><span class=\"oi oi-pencil\"></span>\n            Add Carrier\n        </button>\n        ");
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "type", "button");
                __builder2.AddAttribute(12, "class", "btn btn-secondary");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
                                                                  Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(14, "<span class=\"oi oi-media-skip-backward\"></span>\n            Close\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\AddCarrier.razor"
       
    public Carrier Carrier { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Carrier = new Carrier();
    }

    private async Task AddCarrierAsync()
    {
        await _carrierService.AddCarrierAsync(Carrier);
        Close();
    }

    private void Close()
    {
        _navigationManager.NavigateTo("/CarrierList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CarrierService _carrierService { get; set; }
    }
}
#pragma warning restore 1591