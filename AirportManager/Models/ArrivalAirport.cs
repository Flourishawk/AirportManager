using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.Models
{
    public partial class ArrivalAirport
    {
        public int FlightId { get; set; }

        public int AirportId { get; set; }

        public virtual Flight Flight { get; set; } = null!;

        public virtual AirportConstruction AirportConstruction { get; set; } = null!;
    }
}
