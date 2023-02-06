using AdminApp.Models;

namespace AdminApp.Repositories.IRepositories
{
    public interface IClientRepository: IRepository<Client>
    {
        Client Update(Client client);
    }
}
