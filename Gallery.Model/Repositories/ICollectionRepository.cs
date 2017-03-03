using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model.Repositories
{
    public interface ICollectionRepository : IRepository<Guid, Collection>
    {
    }
}
