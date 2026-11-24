using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Interfaces;

public interface IRepository<T> where T : class, IHarId
{
}
