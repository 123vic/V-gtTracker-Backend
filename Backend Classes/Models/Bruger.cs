using Backend_Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_Classes.Models;

public class Bruger : IHarId
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public int PhoneNumber { get; set; }

}
