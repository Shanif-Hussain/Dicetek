using Dicetek.DomainModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicetek.ServiceContracts
{
    public interface IRegistersService
    {
        Task<IEnumerable<RegisterModel>> GetRegisteredUserList();
        Task RegisterNewUser(RegisterModel reg);
    }
}
