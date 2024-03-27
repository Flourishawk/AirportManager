using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string GenderName { get; set; } = null!;

    public virtual ICollection<Human> Humans { get; set; } = new List<Human>();
}
