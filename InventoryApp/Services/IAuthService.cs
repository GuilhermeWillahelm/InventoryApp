using InventoryApp.Models;

namespace InventoryApp.Services
{
    public interface IAuthService
    {
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<ServiceResponse<bool>> ChangePassowrd(int userId, string newPassowrd);
        int GetUserId();
        string GetUserEmail();
        Task<User> GetUserByEmail(string email);
    }
}
