using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetMVC.Filters
{
    public class SimpleResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            context.HttpContext.Response.Cookies.Append("LastVisit",
           DateTime.Now.ToString("dd/MM/yyyy HH-mm-ss"));
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // Реалізація відсутня
        }
    }
}
