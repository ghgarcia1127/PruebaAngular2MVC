using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gallery.Model.Repositories
{
    public interface IPaintingRepository : IRepository<long, Painting>
    {
        Task<IEnumerable<Painting>> GetByCollectionAsync(long collectionId);
    }
}
