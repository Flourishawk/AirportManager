using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class TicketService : ITicketService
    {
        public void AddTicket(Ticket ticket)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Tickets.Any(e1 => e1.TicketId == ticket.TicketId);
            if (!checkIfExist)
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
            }
        }

        public void UpdateTicket(Ticket ticketBeforeChanges, DateTime departureTime, DateTime purchaseTime, DateTime expirationTime, sbyte? seat, int? passangerId)
        {
            using AirportdbContext db = new();
            Ticket? ticket = db.Tickets.FirstOrDefault(a => a.TicketId == ticketBeforeChanges.TicketId);
            if (ticket != null)
            {
                ticket.DepartureTime = departureTime;
                ticket.PurchaseTime = purchaseTime;
                ticket.ExpirationTime = expirationTime;
                ticket.Seat = seat;
                ticket.PassangerId = passangerId;
            }
            db.SaveChanges();
        }

        public void DeleteTicket(Ticket ticket)
        {
            using AirportdbContext db = new();
            db.Tickets.Remove(ticket);
            db.SaveChanges();
        }

        public List<Ticket> GetAllTickets()
        {
            using AirportdbContext db = new();
            var allTickets = db.Tickets.ToList();
            return allTickets;
        }

        public Ticket GetTicketById(int ticketId)
        {
            using AirportdbContext db = new();
            return db.Tickets.FirstOrDefault(a => a.TicketId == ticketId);
        }
    }
}
