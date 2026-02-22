using Microsoft.EntityFrameworkCore;
using pronto_back.Domain.Entities;
using pronto_back.Domain.Interfaces.Repositories;
using pronto_back.Infrastructure.Persistence;

namespace pronto_back.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        // Instancia de db context

        private readonly ProntoDbContext _context;

        public UserRepository(ProntoDbContext context)
        {

            _context = context;
        }


        public async Task<User?> CreateUser(User user)
        {

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return user;

        }

        public async Task<User?> GetUserByEmail(string email)
        {

            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

           

        }

        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

        }

        public async Task<bool> UserExistsByEmail(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);

            
        }
    }
}
