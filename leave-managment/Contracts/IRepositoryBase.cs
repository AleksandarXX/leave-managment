﻿using System.Collections;
using System.Collections.Generic;

namespace leave_managment.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById (int id);
        bool IsExists (int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();

    }
}
