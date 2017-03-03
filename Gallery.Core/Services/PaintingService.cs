namespace Gallery.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dtos;
    using IServices;
    using Model.Repositories;
    using System.Linq;

    public class PaintingService : IPaintingService
    {
        #region Private Members
        private readonly IPaintingRepository repository;
        #endregion

        #region Constructor
        public PaintingService(IPaintingRepository PaintingRepository)
        {
            repository = PaintingRepository;
        }
        #endregion

        #region IService
        public void Add(Painting entity)
        {
            repository.Add(AutoMapper.Mapper.Map<Model.Painting>(entity));
        }

        public void Delete(Guid id)
        {
            repository.Delete(id);
        }

        public Painting FindById(Guid id)
        {
            return AutoMapper.Mapper.Map<Painting>((repository.FindById(id)));
        }

        public IEnumerable<Painting> GetAll()
        {
            return repository.GetAll().Select(x => AutoMapper.Mapper.Map<Painting>(x));
        }

        public async Task<IEnumerable<Painting>> GetAllAsync()
        {
            return from painting in await repository.GetAllAsync() select AutoMapper.Mapper.Map<Painting>(painting);
        }

        public async Task<IEnumerable<Painting>> GetByCollectionAsync(Guid CollectionId)
        {
            return from painting in await repository.GetByCollectionAsync(CollectionId)
                   select AutoMapper.Mapper.Map<Painting>(painting);
        }
        #endregion
    }
}
