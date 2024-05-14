
using System.Data.Common;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Exceptions;

namespace sda_onsite_2_csharp_backend_teamwork.src.Middlewares
{
    public class CustomeErrorMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine("DB EXCETION HERE");
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync(e.InnerException.Message);

                Console.WriteLine($"ERROR: {e.InnerException.Message}");
            }
            catch (CustomErrorException e)
            {
                context.Response.StatusCode = e.StatusCode;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(e.Message);
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Sorry, something went wrong!");

                Console.WriteLine($"ERROR: {e.Message}");
            }

        }
    }
}
