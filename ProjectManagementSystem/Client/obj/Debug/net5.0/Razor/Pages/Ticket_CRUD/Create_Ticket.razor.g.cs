#pragma checksum "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3ad6df21730d5ee36631e3f0b3105b99bd381f"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Pages.Ticket_CRUD
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/create_ticket/{Id:guid}")]
    public partial class Create_Ticket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-outline-secondary oi oi-arrow-left");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                                                         GoToHome

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<h3 class=\"text-center display-3\">Create Ticket</h3>");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                 Ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group row");
                __builder2.AddMarkupContent(13, "<label for=\"Name\" class=\"col-sm-2 col-form-label\">Name</label>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "Name");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                                                                      Ticket.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Name = __value, Ticket.Name))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Ticket.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __Blazor.ProjectManagementSystem.Client.Pages.Ticket_CRUD.Create_Ticket.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 19 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                      () => Ticket.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group row");
                __builder2.AddMarkupContent(29, "<label for=\"Description\" class=\"col-sm-2 col-form-label\">Description</label>\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "Description");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "placeholder", "Description");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                                                                                    Ticket.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Description = __value, Ticket.Description))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Ticket.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __Blazor.ProjectManagementSystem.Client.Pages.Ticket_CRUD.Create_Ticket.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 27 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                      () => Ticket.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "<label for=\"Priority\" class=\"col-sm-2 col-form-label\">Priority</label>\r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-sm-10");
                __Blazor.ProjectManagementSystem.Client.Pages.Ticket_CRUD.Create_Ticket.TypeInference.CreateInputSelect_2(__builder2, 48, 49, "Priority", 50, "form-control", 51, 
#nullable restore
#line 34 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                                                          Ticket.Priority

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Priority = __value, Ticket.Priority)), 53, () => Ticket.Priority, 54, (__builder3) => {
#nullable restore
#line 35 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                 foreach (var priority in Enum.GetValues(typeof(TicketPriority)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 37 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                    priority

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(57, 
#nullable restore
#line 37 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                               priority

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 38 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(58, "\r\n            ");
                __Blazor.ProjectManagementSystem.Client.Pages.Ticket_CRUD.Create_Ticket.TypeInference.CreateValidationMessage_3(__builder2, 59, 60, 
#nullable restore
#line 40 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
                                      () => Ticket.Priority

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n    <hr>\r\n\r\n    ");
                __builder2.AddMarkupContent(62, "<div class=\"row justify-content-md-center\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Ticket_CRUD\Create_Ticket.razor"
       
    private void GoToHome()
    {
        Navigation.NavigateTo("/");
    }

    [Parameter] public Guid Id { get; set; }
    private Board Board { get; set; } = new Board();
    private Ticket Ticket { get; set; } = new Ticket();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Board = await Http.GetFromJsonAsync<Board>($"api/Boards/{Id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private async void HandleValidSubmit()
    {
        try
        {
            Console.WriteLine("VALID SUBMIT!");

            Ticket newTicket = new Ticket(Ticket.Name, Ticket.Description, Ticket.Priority, Ticket.BoardId);

            newTicket.BoardId = Board.Id;

            var response = await Http.PostAsJsonAsync("/api/Tickets", newTicket);
            response.EnsureSuccessStatusCode();

            Navigation.NavigateTo($"/read_board/{Id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
namespace __Blazor.ProjectManagementSystem.Client.Pages.Ticket_CRUD.Create_Ticket
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
