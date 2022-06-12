using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MySite.MiddleWares
{
    public class ViewDataMiddleware 
    {
        private readonly RequestDelegate _next;
 
        public ViewDataMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            context.Items.Add("Year", DateTime.Now.Year.ToString());
            await _next.Invoke(context);
        }
    }
}