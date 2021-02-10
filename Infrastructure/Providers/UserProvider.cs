using Microsoft.AspNetCore.Http;
using PROJECT.Infrastructure.Providers.Interfaces;

namespace PROJECT.Infrastructure.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string Get()
        {
            string username = _httpContextAccessor.HttpContext.User.FindFirst("name")?.Value;
            string employeeId = _httpContextAccessor.HttpContext.User.FindFirst("employeeId")?.Value;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(employeeId))
            {
                return username + " (" + employeeId + ")";
            }

            return null;
        }

        public string GetName()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst("name")?.Value;
        }

        public string GetId()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst("employeeId")?.Value;
        }
    }
}
