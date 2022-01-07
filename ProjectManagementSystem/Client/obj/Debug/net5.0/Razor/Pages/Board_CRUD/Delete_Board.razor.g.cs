#pragma checksum "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Board_CRUD\Delete_Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6bacf6ae7d210096b0e10eb274373ea85d7f12"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Pages.Board_CRUD
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete_board/{Id:guid}")]
    public partial class Delete_Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-outline-secondary oi oi-arrow-left");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Board_CRUD\Delete_Board.razor"
                                                                         GoToHome

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<h3 style=\"padding-left:25%;\">Are you sure you want to delete this board?</h3>");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row justify-content-md-center");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-3");
            __builder.OpenComponent<ProjectManagementSystem.Client.Shared.BoardPreview>(11);
            __builder.AddAttribute(12, "CardTitle", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(13, 
#nullable restore
#line 16 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Board_CRUD\Delete_Board.razor"
                        Board.Name

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(14, "CardDesc", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(15, 
#nullable restore
#line 17 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Board_CRUD\Delete_Board.razor"
                       Board.Description

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row justify-content-md-center");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Board_CRUD\Delete_Board.razor"
                                              DeleteBoard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Board_CRUD\Delete_Board.razor"
       
    [Parameter] public Guid Id { get; set; }
    private Board Board { get; set; } = new Board();
    private List<Board> Boards = new List<Board>();

    private void GoToHome()
    {
        Navigation.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Board = await Http.GetFromJsonAsync<Board>($"api/Boards/{Id}");
            Boards = await Http.GetFromJsonAsync<List<Board>>("/api/Boards");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    protected async Task DeleteBoard()
    {
        try
        {
            await Http.DeleteAsync($"api/Boards/{Id}");
            Navigation.NavigateTo("/");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
