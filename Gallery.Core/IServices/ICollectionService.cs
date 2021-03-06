﻿

namespace Gallery.Core.IServices
{
    using Dtos;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICollectionService
    {
        IEnumerable<Collection> GetAll();

        Task<IEnumerable<Collection>> GetAllAsync();

        void Add(Collection entity);

        void Delete(long id);

        Collection FindById(long id);
    }
}
