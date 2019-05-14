using System;
using MGG.Crud.Services.Models;

namespace MGG.Crud.Services.Interfaces.IServices
{
    public interface IUserService : IDisposable
    {
        void Create(User user);

        User Read(Guid id);

        void Update(User user);

        void Delete(Guid id);
    }
}