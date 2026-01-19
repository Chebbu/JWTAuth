using JWTAuth.DTO;
using JWTAuth.Entities;

namespace JWTAuth.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
