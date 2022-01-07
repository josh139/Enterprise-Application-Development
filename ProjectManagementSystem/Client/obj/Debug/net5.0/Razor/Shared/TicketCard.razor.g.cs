#pragma checksum "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec600fb977a6f0eacde395caf3544444c20269ad"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Shared
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
    public partial class TicketCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "draggable");
            __builder.AddAttribute(2, "draggable", "true");
            __builder.AddAttribute(3, "title", 
#nullable restore
#line 1 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
                                               Ticket.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
                                                                                   () => HandleDragStart(Ticket)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "b-qlhocnhn2h");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 2 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
               backgroundClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "style", "text-align:center;");
            __builder.AddAttribute(9, "b-qlhocnhn2h");
            __builder.AddContent(10, 
#nullable restore
#line 2 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
                                                            Ticket.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    <hr b-qlhocnhn2h>\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "description");
            __builder.AddAttribute(14, "style", "text-align:center;");
            __builder.AddAttribute(15, "b-qlhocnhn2h");
            __builder.AddContent(16, 
#nullable restore
#line 4 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
                                                       Ticket.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "last-updated");
            __builder.AddAttribute(20, "style", "text-align:center;");
            __builder.AddAttribute(21, "b-qlhocnhn2h");
            __builder.AddMarkupContent(22, "<small b-qlhocnhn2h>Last Updated</small> ");
            __builder.AddContent(23, 
#nullable restore
#line 5 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
                                                                                    Ticket.LastUpdated.ToString("HH:mm:ss")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Shared\TicketCard.razor"
       
    [CascadingParameter] TicketsContainer Container { get; set; }
    [Parameter] public Ticket Ticket { get; set; }
    string backgroundClass = "";

    protected override void OnParametersSet()
    {
        if (Ticket.Priority == TicketPriority.Crucial)
        {
            backgroundClass = "background-crucial";
        }

        else if (Ticket.Priority == TicketPriority.High)
        {
            backgroundClass = "background-high";
        }

        else if (Ticket.Priority == TicketPriority.Medium)
        {
            backgroundClass = "background-medium";
        }

        else
        {
            backgroundClass = "background-low";
        }

    }

    private void HandleDragStart(Ticket selectedTicket)
    {
        Container.Ticket = selectedTicket;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591