using System.Security.Claims;
using Sober.Application.Contracts;

#nullable disable

namespace Sober.API.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid? UserId => new Guid(_httpContextAccessor.HttpContext?.User.FindFirstValue("sub"));

    }
}
