using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class DailyOverview : IHasId
{
    public int Id { get; set; }

    public DateTime Dato { get; set; }

   List<Meal> Måltider { get; set; }
}
