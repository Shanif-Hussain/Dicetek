using Dicetek.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dicetek.RepositoryContracts
{
    public interface IRegistersRepository
    {
        Task<IEnumerable<RegisterModel>> GetRegisteredUserList();
        Task RegisterNewUser(RegisterModel reg);
    }
}
