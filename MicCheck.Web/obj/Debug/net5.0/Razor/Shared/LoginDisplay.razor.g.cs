#pragma checksum "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab8ed40317c4fd8a58ba0e9f694b154d0ad0ba9"
// <auto-generated/>
#pragma warning disable 1591
namespace MicCheck.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "Identity/Account/Manager");
                __builder2.AddAttribute(4, "b-hltfv0agda");
                __builder2.AddContent(5, " Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 3 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Shared\LoginDisplay.razor"
                                                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<form method=\"post\" action=\"Identity/Account/LogOut\" b-hltfv0agda><button class=\"nav-link btn btn-link\" type=\"submit\" b-hltfv0agda>Log out</button></form>");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<a href=\"Identity/Account/Register\" b-hltfv0agda> Register </a>\r\n        ");
                __builder2.AddMarkupContent(11, "<a href=\"Identity/Account/Login\" b-hltfv0agda> Login</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
