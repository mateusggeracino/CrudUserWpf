using System;

namespace MGG.Crud.Services.Interfaces.IRepository
{
    public interface IRepository<TEntity> : IDisposable
    {
        void Create(TEntity obj);

        TEntity Read(Guid id);

        void Update(TEntity obj);

        void Delete(Guid id);
    }
}