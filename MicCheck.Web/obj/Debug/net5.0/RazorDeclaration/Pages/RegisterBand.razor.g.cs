// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MicCheck.Web.Pages
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
#line 7 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\RegisterBand.razor"
using MicCheck.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register/band")]
    public partial class RegisterBand : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "F:\projetoscaio\Bluprints\MicCheck\MicCheck.Web\Pages\RegisterBand.razor"
 
    RegisterBandModel Band = new RegisterBandModel();
    bool loading = false;

    protected override async Task OnInitializedAsync()
    {
    }

    private void CreateBand()
    {
        Console.WriteLine("Clicked on create band man!");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MicCheck.Web.Services.Interfaces.IAuthenticationService AuthenticationService { get; set; }
    }
}
#pragma warning restore 1591