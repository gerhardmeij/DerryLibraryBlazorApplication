using DerryLibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerryLibraryAPI.Repositories.Services
{
    public class UserService
    {
        private readonly DerryLibraryContext _db;

        public UserService(DerryLibraryContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(User entity)
        {
            _db.Users.Remove(entity);
            return await Save();
        }

        public async Task<IList<User>> FindAll()
        {
            var authors = await _db.Users.ToListAsync();
            return authors;
        }

        public async Task<User> FindById(int id)
        {
            var author = await _db.Users.FirstOrDefaultAsync(x => x.Id == id);
            return author;
        }

        public async Task<bool> isExists(int id)
        {
            return await _db.Users.AnyAsync(q => q.Id == id);
        }

        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<bool> Update(User entity)
        {
            _db.Users.Update(entity);
            return await Save();
        }

    }
}
