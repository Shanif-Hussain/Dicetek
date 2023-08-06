using Dicetek.DomainLayer;
using Dicetek.DomainModels;
using Dicetek.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicetek.RepositoryLayer
{
    public class RegistersRepository : IRegistersRepository
    {
        private readonly RegisterDbContext _context;

        public RegistersRepository(RegisterDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RegisterModel>> GetRegisteredUserList()
        {
            return await _context.Registers.ToListAsync();
        }

        public async Task RegisterNewUser(RegisterModel reg)
        {
            _context.Add(reg);
            await _context.SaveChangesAsync();
        }
    }
}
