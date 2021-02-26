using MicCheck.API.Responses;
using MicCheck.API.Responses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MicCheck.API.Middlewares
{
    // With this middleware, we are able to define what our API should do in each specific scenario of exceptions
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILogger logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    IExceptionHandlerFeature contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        BaseResponse response = new BaseResponse();
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                        switch (context.Response.StatusCode)
                        {
                            // Here we can customize a message foreach status code errors
                            case 500:
                                response.Message = "Internal server error!";
                                break;

                            case 403:
                                response.Message = "Sorry but you're not allowed to access this feature!";
                                break;

                            default:
                                response.Message = "Something went wrong!";
                                break;
                        }

                        await context.Response.WriteAsync(response.ToString());
                    }
                });
            });
        }
       
    }
}
