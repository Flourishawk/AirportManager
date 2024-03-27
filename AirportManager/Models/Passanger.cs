using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Passanger
{
    public int PassangerId { get; set; }

    public virtual ICollection<Human> Humans { get; set; } = new List<Human>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
