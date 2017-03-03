

namespace Gallery.Data
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;

    public interface IUnitOfWork : IDisposable
    {
        DbSet<TEntity> GetSet<TEntity>() where TEntity : Entity;

        void Commit();

        Task CommitAsync();

        IUnitOfWork UnitOfWork { get; }
    }
}
