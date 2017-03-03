

namespace Gallery.Core.IServices
{
    using Dtos;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPaintingService
    {
        IEnumerable<Painting> GetAll();

        Task<IEnumerable<Painting>> GetAllAsync();

        Task<IEnumerable<Painting>> GetByCollectionAsync(Guid CollectionId);

        void Add(Painting entity);

        void Delete(Guid id);

        Painting FindById(Guid id);
    }
}
