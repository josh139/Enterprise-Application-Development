#pragma checksum "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6616d6bbfa1ad353a24c152c3fadbc62a6a48eee"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Pages.Company_CRUD
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/create_company")]
    public partial class Create_Company : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-outline-secondary oi oi-arrow-left");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                                                                         GoToReadCompany

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<h3 class=\"text-center display-3\">Create Company</h3>");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                 Company

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ObjectGraphDataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row");
                __builder2.AddMarkupContent(15, "<label for=\"Name\" class=\"col-sm-2 col-form-label\">Name</label>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "Name");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "Name");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                                                                                      Company.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Company.Name = __value, Company.Name))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Company.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.ProjectManagementSystem.Client.Pages.Company_CRUD.Create_Company.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 20 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                                      () => Company.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddMarkupContent(31, "<label for=\"CompanyFounded\" class=\"col-sm-2 col-form-label\">Founded</label>\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-sm-10");
                __Blazor.ProjectManagementSystem.Client.Pages.Company_CRUD.Create_Company.TypeInference.CreateInputDate_1(__builder2, 34, 35, "CompanyFounded", 36, "form-control", 37, 
#nullable restore
#line 27 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                                                                             Company.Founded

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Company.Founded = __value, Company.Founded)), 39, () => Company.Founded);
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.ProjectManagementSystem.Client.Pages.Company_CRUD.Create_Company.TypeInference.CreateValidationMessage_2(__builder2, 41, 42, 
#nullable restore
#line 28 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
                                      () => Company.Founded

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n    <hr>\r\n\r\n    ");
                __builder2.AddMarkupContent(44, "<div class=\"row justify-content-md-center\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\jbors\source\repos\ProjectManagementSystem\Client\Pages\Company_CRUD\Create_Company.razor"
       
    private void GoToReadCompany()
    {
        Navigation.NavigateTo("/read_companies");
    }

    private Company Company { get; set; } = new Company("", new DateTime());

    private async void HandleValidSubmit()
    {
        try
        {
            Console.WriteLine("VALID SUBMIT!");

            Company newCompany = new Company(Company.Name, Company.Founded);

            var response = await Http.PostAsJsonAsync("api/Companies", newCompany);
            response.EnsureSuccessStatusCode();

            Navigation.NavigateTo("/read_companies");
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
namespace __Blazor.ProjectManagementSystem.Client.Pages.Company_CRUD.Create_Company
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
