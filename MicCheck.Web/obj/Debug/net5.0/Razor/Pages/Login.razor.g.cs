#pragma checksum "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a055abfc6fbb52d126ff23f72554e4afefd0e1"
// <auto-generated/>
#pragma warning disable 1591
namespace MicCheck.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using MicCheck.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using MicCheck.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using MicCheck.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
using MicCheck.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
using MicCheck.Web.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
using MicCheck.Shared.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login/band")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login/fan")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-6 offset-md-3 mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "h4");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddContent(6, 
#nullable restore
#line 14 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                 roleLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " Authentication");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                              model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "<label>Username</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                            model.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Username = __value, model.Username))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __Blazor.MicCheck.Web.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 21 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                              () => model.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label>Password</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                            model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __Blazor.MicCheck.Web.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 26 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                              () => model.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "class", "btn btn-primary");
#nullable restore
#line 29 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                     if (loading)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(44, "<span class=\"spinner-border spinner-border-sm mr-1\"></span>");
#nullable restore
#line 32 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(45, "                    Login\r\n                ");
                __builder2.CloseElement();
#nullable restore
#line 35 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                 if (!string.IsNullOrEmpty(error))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "alert alert-danger mt-3 mb-0");
                __builder2.AddContent(48, 
#nullable restore
#line 37 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                                                               error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 38 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\Login.razor"
       
    private Model model = new Model();
    private bool loading;
    private string error;
    private string roleLabel = "Band";

    protected override void OnInitialized()
    {
        if (NavigationManager.Uri.Split('/')?.Last().ToUpper() == "FAN")
        {
            roleLabel = "Fan";
        }

        // redirect to home if already logged in
        if (authenticationService.Token != null)
        {
            NavigationManager.NavigateTo("/home");
        }
    }

    private async void HandleValidSubmit()
    {
        loading = true;
        try
        {
            BaseResponse response = await authenticationService.Login(model.Username, model.Password, roleLabel);
            if (response.Success)
            {
                //toastService.ShowSuccess(response.Message);
                //await Task.Delay(5000);
                var returnUrl = NavigationManager.QueryString("returnUrl") ?? "/home";
                NavigationManager.NavigateTo(returnUrl);

            }
            else
            {
                //toastService.ShowError(response.Message);
            }

        }
        catch (Exception ex)
        {
            error = ex.Message;
            StateHasChanged();
        }
        finally
        {
            loading = false;
        }
    }

    private class Model
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService authenticationService { get; set; }
    }
}
namespace __Blazor.MicCheck.Web.Pages.Login
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
    }
}
#pragma warning restore 1591
