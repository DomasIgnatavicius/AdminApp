using AdminApp.Data;
using AdminApp.Models;
using AdminApp.Repositories.IRepositories;

namespace AdminApp.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly ShopContext _db;
        public ClientRepository(ShopContext db) : base(db)
        {
            _db = db;
        }
        public Client Update(Client client)
        {
            client.UpdateDateTime = DateTime.Now;
            _db.Clients.Update(client);
            _db.SaveChanges();
            return client;
        }
    }
}
