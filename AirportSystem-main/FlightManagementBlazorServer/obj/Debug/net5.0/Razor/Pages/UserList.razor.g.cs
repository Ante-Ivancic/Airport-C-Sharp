#pragma checksum "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84afb2b2b82dafbe1875953786d427443870e17"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserList")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>User List</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
                                ShowAddUserPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "btn btn-success");
            __builder.AddMarkupContent(5, "<span class=\"oi oi-plus\"></span>\r\n    Add User\r\n");
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
 if (Users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Loading...</p>");
#nullable restore
#line 13 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-responsive");
            __builder.AddMarkupContent(9, "<thead><tr><th>Name</th>\r\n                <th>Surname</th>\r\n                <th>Username</th>\r\n                <th>Role</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 26 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
             foreach (var user in Users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line 29 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
__builder.AddContent(13, user.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 30 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
__builder.AddContent(16, user.Surname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 31 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
__builder.AddContent(19, user.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 32 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
__builder.AddContent(22, user.Role);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Lijana\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\UserList.razor"
       
    public List<User> Users { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Users = await GetUsersAsync();
    }
    private void ShowAddUserPage()
    {
        _navigationManager.NavigateTo("/AddUser");
    }
    private async Task<List<User>> GetUsersAsync()
    {
        return await _userService.GetUsersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
