#pragma checksum "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ba12daacc297d5fe634170856cfc4e0af31509b"
// <auto-generated/>
#pragma warning disable 1591
namespace MicCheck.Web
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
#nullable restore
#line 11 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\_Imports.razor"
using MicCheck.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\App.razor"
using MicCheck.Web.Helpers;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 3 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", 
#nullable restore
#line 3 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<MicCheck.Web.Helpers.AppRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 5 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\App.razor"
                                  routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\App.razor"
                                                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "<h1></h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
