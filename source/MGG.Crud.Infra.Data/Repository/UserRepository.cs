using MGG.Crud.Infra.Data.Context;
using MGG.Crud.Services.Interfaces.IRepository;
using MGG.Crud.Services.Models;

namespace MGG.Crud.Infra.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CrudContext con) : base(con)
        {
        }
    }
}