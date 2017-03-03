using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gallery.Model.Repositories
{
    public interface IPaintingRepository : IRepository<Guid, Painting>
    {
        Task<IEnumerable<Painting>> GetByCollectionAsync(Guid collectionId);
    }
}
