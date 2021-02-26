using MicCheck.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MicCheck.Web.Helpers
{
    public class AppRouteView : RouteView
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        protected override void Render(RenderTreeBuilder builder)
        {
            var authorize = Attribute.GetCustomAttribute(RouteData.PageType, typeof(AuthorizeAttribute)) != null;
            //Here we sent unauthorized users back to login page
            if (authorize && AuthenticationService.Token == null)
            {
                try
                {
                    NavigationManager.NavigateTo("/");
                }
                catch (Microsoft.AspNetCore.Components.NavigationException e)
                {

                }
            }
            else
            {
                base.Render(builder);
            }
        }
    }
}
