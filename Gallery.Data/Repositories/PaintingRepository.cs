namespace Gallery.Data.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Model.Repositories;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Data.Entity;
    using System;

    public class PaintingRepository : IPaintingRepository
    {
        #region Private Members
        private readonly IUnitOfWork unitOfWork;
        #endregion

        #region Construction
        public PaintingRepository(IUnitOfWork GalleryContext)
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

        public void Add(Painting entity)
        {
            if (entity != null)
            {
                (this.unitOfWork.GetSet<Painting>()).AddOrUpdate(entity);
                unitOfWork.Commit();
            }
        }

        public void Delete(Painting entity)
        {
            (this.unitOfWork.GetSet<Painting>()).Remove(entity);
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

        public Painting FindById(long id)
        {
            return unitOfWork.GetSet<Painting>().Find(id);
        }

        public async Task<Painting> FindByIdAsync(long id)
        {
            return await unitOfWork.GetSet<Painting>().FindAsync(id);
        }

        public IEnumerable<Painting> GetAll()
        {
            return (unitOfWork.GetSet<Painting>()).ToList();
        }

        public async Task<IEnumerable<Painting>> GetAllAsync()
        {
            return await unitOfWork.GetSet<Painting>().OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<IEnumerable<Painting>> GetByCollectionAsync(long collectionId)
        {
            return await unitOfWork.GetSet<Painting>().Where(P => P.Collection_Id.Equals(collectionId)).ToListAsync();
        }

        #endregion
    }
}
