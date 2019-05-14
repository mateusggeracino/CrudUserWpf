using System;
using MGG.Crud.Infra.Data.Context;
using MGG.Crud.Services.Interfaces.IRepository;
using MGG.Crud.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace MGG.Crud.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected CrudContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(CrudContext con)
        {
            Db = con;
            DbSet = Db.Set<TEntity>();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public void Create(TEntity obj)
        {
            DbSet.Add(obj);
            Db.SaveChanges();
        }

        public TEntity Read(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
            Db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(Read(id));
            Db.SaveChanges();
        }
    }
}