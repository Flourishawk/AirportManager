using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public DateTime DepartureTime { get; set; }

    public DateTime PurchaseTime { get; set; }

    public DateTime ExpirationTime { get; set; }

    public sbyte? Seat { get; set; }

    public int? PassangerId { get; set; }

    public virtual Passanger? Passanger { get; set; }
}
