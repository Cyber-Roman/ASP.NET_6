using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace AspNetMVC.Filters
{
    public class LogActionFilter : IActionFilter
    {
        private readonly string logFilePath = "log.txt";

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string actionName = context.ActionDescriptor.DisplayName;
            string timestamp = DateTime.Now.ToString();

            string logEntry = $"Action '{actionName}' accessed at {timestamp}\n";

            File.AppendAllText(logFilePath, logEntry, Encoding.UTF8);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do nothing on action executed
        }
    }
}
