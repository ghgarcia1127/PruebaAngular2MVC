
namespace Gallery.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dtos;
    using IServices;
    using Model.Repositories;
    using System.Linq;

    public class CollectionService : ICollectionService
    {
        #region Private members
        private ICollectionRepository repository;
        #endregion

        #region Costructor
        public CollectionService(ICollectionRepository collectionRepository)
        {
            this.repository = collectionRepository;
        }
        #endregion

        #region ICollectionService Members
        public void Add(Collection entity)
        {

            repository.Add(AutoMapper.Mapper.Map<Model.Collection>(entity));
        }

        public void Delete(long id)
        {
            repository.Delete(id);
        }

        public Collection FindById(long id)
        {
            return AutoMapper.Mapper.Map<Collection>(repository.FindById(id));
        }

        public IEnumerable<Collection> GetAll()
        {
            return repository.GetAll().Select(c => AutoMapper.Mapper.Map<Collection>(c));
        }

        public async Task<IEnumerable<Collection>> GetAllAsync()
        {
            return from collection in await repository.GetAllAsync() select AutoMapper.Mapper.Map<Collection>(collection);
        }
        #endregion
    }
}
