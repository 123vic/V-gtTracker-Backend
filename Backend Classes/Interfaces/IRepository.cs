using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Interfaces;

public interface IRepository<T> where T : class, IHasId
{
    Dictionary<int, T> Data { get; }

    T? GetItem(int id);
    void Create(T t);
    bool Delete(int id);
    void Update(T t);
}
