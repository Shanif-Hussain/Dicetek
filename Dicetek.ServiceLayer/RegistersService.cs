using Dicetek.DomainModels;
using Dicetek.RepositoryContracts;
using Dicetek.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicetek.ServiceLayer
{
    public class RegistersService : IRegistersService
    {
        private readonly IRegistersRepository _context;

        public RegistersService(IRegistersRepository context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RegisterModel>> GetRegisteredUserList()
        {
            return await _context.GetRegisteredUserList();
        }

        public async Task RegisterNewUser(RegisterModel reg)
        {
            await _context.RegisterNewUser(reg);
        }
    }
}
