
namespace Gallery.Data.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Model.Repositories;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System;

    public class CollectionRepository : ICollectionRepository
    {
        #region Private Members
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Construction
        public CollectionRepository(IUnitOfWork GalleryContext)
        {
            unitOfWork = GalleryContext;
        }
        #endregion

        #region IRepository Members
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return unitOfWork;
            }
        }
        public void Add(Collection entity)
        {
            if (entity != null)
            {
                (this.unitOfWork.GetSet<Collection>()).AddOrUpdate(entity);
                unitOfWork.Commit();
            }
        }

        public void Delete(Collection entity)
        {
            (this.unitOfWork.GetSet<Collection>()).Remove(entity);
            unitOfWork.Commit();
        }

        public void Delete(long id)
        {
            Delete(this.FindById(id));
        }

        public void Dispose()
        {
            this.unitOfWork.Dispose();
        }

        public Collection FindById(long id)
        {
            return unitOfWork.GetSet<Collection>().Find(id);
        }

        public async Task<Collection> FindByIdAsync(long id)
        {
            return await unitOfWork.GetSet<Collection>().FindAsync(id);
        }

        public IEnumerable<Collection> GetAll()
        {
            return  (unitOfWork.GetSet<Collection>()).ToList();
        }

        public async Task<IEnumerable<Collection>> GetAllAsync()
        {
           return await unitOfWork.GetSet<Collection>().OrderBy(e => e.Name).ToListAsync();
        }
        #endregion
    }
}
