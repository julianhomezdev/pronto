using pronto_back.Domain.Entities;

namespace pronto_back.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {

        Task<User?> CreateUser(User user);

        Task<User?> GetUserById(int id);

        Task<User?> GetUserByEmail(string email);

        Task<bool> UserExistsByEmail(string email);



    }
}
