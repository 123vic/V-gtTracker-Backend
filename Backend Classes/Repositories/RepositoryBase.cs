using Backend_Classes.Interfaces;
using Backend_Classes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Repositories;

public abstract class RepositoryBase<T> : IRepository<T> where T : class, IHarId
{
    public Dictionary<int, T> Data { get; }
    private static int newId;

    public RepositoryBase()
    {
        Data = new Dictionary<int, T>();
    }

    public T? GetItem(int id)
    {
        return Data.TryGetValue(id, out T? item) ? item : null;
    }

    public void Create(T t)
    {
        t.Id = GenerateId();
        Data.Add(t.Id, t);
    }

    public bool Delete(int id)
    {
        return Data.Remove(id);
    }

    public void Update(T t)
    {
        if (Data.ContainsKey(t.Id))
        {
            Data[t.Id] = t;
        }
    }



    private int GenerateId()
    {
       newId++;
       return newId;
    }
}
