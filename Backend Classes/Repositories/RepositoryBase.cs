using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Repositories;

public abstract class RepositoryBase<T> where T : class, IHarId
{
    public Dictionary<int, T> Data { get; } = new();

}
