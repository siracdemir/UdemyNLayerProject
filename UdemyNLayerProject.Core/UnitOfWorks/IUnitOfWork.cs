﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Core.UnitOfWorks
{
    interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Category { get; }
        Task CommitAsync();

        void Commit();
    }
}
