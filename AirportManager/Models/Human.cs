using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Human
{
    public int HumanId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    public int? GenderId { get; set; }

    public int? PassangerId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual Passanger? Passanger { get; set; }
}
