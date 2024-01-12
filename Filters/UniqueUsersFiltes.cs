using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using System.Text;

namespace AspNetMVC.Filters
{
    public class UniqueUsersFilter : IActionFilter
    {
        private readonly string usersFilePath = "users.txt";

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string userIpAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();

            // Check if user's IP address is already recorded
            if (!File.ReadAllLines(usersFilePath, Encoding.UTF8).Contains(userIpAddress))
            {
                // If not, record it
                File.AppendAllText(usersFilePath, userIpAddress + "\n", Encoding.UTF8);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do nothing on action executed
        }
    }
}
