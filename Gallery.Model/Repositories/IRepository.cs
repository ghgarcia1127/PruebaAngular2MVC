namespace Gallery.Model.Repositories
{
    using Domain;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<TId, TEntity> : IDisposable
        where TId : struct
        where TEntity : Entity
    {
        void Add(TEntity entity);
        void Delete(TId id);
        void Delete(TEntity entity);
        TEntity FindById(TId id);
        Task<TEntity> FindByIdAsync(TId id);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();

    }
}
