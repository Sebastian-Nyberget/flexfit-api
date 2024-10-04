
using flexfit.Models.Users;

namespace flexfit.Services.Users;

public interface IUserService {
    Task<List<User>> GetUsersAsync();

    Task<bool> CreateUser(User user);
}