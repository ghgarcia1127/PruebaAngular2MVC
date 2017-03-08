

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

        Task<IEnumerable<Painting>> GetByCollectionAsync(long CollectionId);

        void Add(Painting entity);

        void Delete(long id);

        Painting FindById(long id);
    }
}
