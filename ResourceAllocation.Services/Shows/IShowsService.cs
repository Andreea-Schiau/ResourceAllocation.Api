﻿using System;
using System.Collections.Generic;
using ResourceAllocation.Domain;

namespace ResourceAllocation.Services.Shows
{
    public interface IShowsService
    {
        void Add(ShowEntity entity);
        void Delete(Guid id);
        IEnumerable<ShowEntity> GetAll();
        ShowEntity GetById(Guid id);
        void Update(ShowEntity entity);
    }
}
