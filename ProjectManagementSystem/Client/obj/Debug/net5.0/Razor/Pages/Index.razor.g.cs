#pragma checksum "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c92620db83d7973b7db9f55a35a73b53a98f8027"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using ProjectManagementSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using ProjectManagementSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using ProjectManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center display-3\">Here are your Boards</h1>\r\n\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"text-center shadow p-3 bg-white rounded\">Welcome to my Project Management System Application! *Please Register/Login to get started*</div>\r\n\r\n<hr>");
#nullable restore
#line 14 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
 foreach (var company in Companies)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, 
#nullable restore
#line 16 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                           company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
#nullable restore
#line 18 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
         foreach (var board in company.Boards)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-3");
            __builder.AddAttribute(11, "style", "padding-bottom:2%; text-align:left");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "padding-bottom:4%;");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/delete_board/" + (
#nullable restore
#line 22 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                                            board.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-outline-secondary oi oi-minus");
            __builder.AddAttribute(17, "style", "text-align:left");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/update_board/" + (
#nullable restore
#line 23 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                                            board.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-outline-secondary oi oi-pencil");
            __builder.AddAttribute(22, "style", "text-align:right");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenComponent<ProjectManagementSystem.Client.Shared.BoardPreview>(24);
            __builder.AddAttribute(25, "CardTitle", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(26, "a");
                __builder2.AddAttribute(27, "href", "/read_board/" + (
#nullable restore
#line 26 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                                                     board.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "class", "stretched-link");
                __builder2.AddAttribute(29, "style", "text-decoration:none; color:black;");
                __builder2.AddContent(30, 
#nullable restore
#line 26 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                                                                                                                                  board.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(31, "CardDesc", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, 
#nullable restore
#line 27 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                               board.Description

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-sm-1");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-outline-secondary oi oi-plus");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
                                                                           GoToCreateBoard

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n<hr>");
#nullable restore
#line 36 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Index.razor"
       
    private List<Company> Companies = new List<Company>();


    protected override async Task OnInitializedAsync()
    {
        try
        {
            Companies = await Http.GetFromJsonAsync<List<Company>>("api/Companies");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void GoToCreateBoard()
    {
        Navigation.NavigateTo("/create_board");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
